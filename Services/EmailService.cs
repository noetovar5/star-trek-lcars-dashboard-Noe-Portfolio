using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DailyDashboard.Services
{
    public class EmailSettings
    {
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; } = 587;
        public bool EnableSsl { get; set; } = true;
        public string Username { get; set; } = string.Empty; // your Gmail
        public string Password { get; set; } = string.Empty; // app password
        public string To { get; set; } = string.Empty;       // destination address
    }

    public interface IEmailService
    {
        Task SendContactAsync(string name, string email, string subject, string message);
    }

    public class SmtpEmailService : IEmailService
    {
        private readonly EmailSettings _settings;
        private readonly ILogger<SmtpEmailService> _logger;

        public SmtpEmailService(IOptions<EmailSettings> options,
                                ILogger<SmtpEmailService> logger)
        {
            _settings = options.Value;
            _logger = logger;
        }

        public async Task SendContactAsync(string name, string email, string subject, string message)
        {
            using var client = new SmtpClient
            {
                Host = _settings.Host,
                Port = _settings.Port,
                EnableSsl = _settings.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false, // IMPORTANT for Gmail
                Credentials = new NetworkCredential(_settings.Username, _settings.Password),
                Timeout = 20000
            };

            using var mail = new MailMessage
            {
                From = new MailAddress(_settings.Username, "Noe Tovar-MBA Portfolio"),
                Subject = subject,
                Body = $"From: {name} <{email}>\n\nMessage:\n{message}",
                IsBodyHtml = false
            };

            // Where the message goes
            mail.To.Add(_settings.To);

            // So you can hit Reply to respond directly to the sender
            if (!string.IsNullOrWhiteSpace(email))
            {
                mail.ReplyToList.Add(new MailAddress(email));
            }

            try
            {
                _logger.LogInformation(
                    "Sending email via {Host}:{Port} as {User} to {To}",
                    _settings.Host,
                    _settings.Port,
                    _settings.Username,
                    _settings.To);

                await client.SendMailAsync(mail);

                _logger.LogInformation("Email sent successfully.");
            }
            catch (SmtpException smtpEx)
            {
                _logger.LogError(smtpEx, "SMTP error sending email.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error sending email.");
                throw;
            }
        }
    }
}
