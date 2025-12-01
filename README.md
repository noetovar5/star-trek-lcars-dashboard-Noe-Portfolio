# star-trek-lcars-dashboard-Noe-Portfolio
<p align="center">
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=js,html,css,git,dotnet&perline=12" />
  </a>
</p>


,C#,github,vscode,git,powershell,proxmox,visualstudio,vscode,ubuntu,dotne


<img align="right" src="https://visitor-badge.laobi.icu/badge?page_id=noetovar5.WindowsEventLogReporter"/>
<div align="center">
<br />
<img width="2100" height="720" alt="tasktrove-banner" src="https://github.com/noetovar5/portfolio/blob/main/Star%20Trek%20Theme%20Portfolio.jpg" />
<br />

<br />

<br />

<div align="center"> Watch Video https://github.com/noetovar5/portfolio/blob/main/Star%20Trek%20Themed%20Noe%20Tovar%20Portofolio%20dotnet%20blazor%20app.mp4
<p align="center">
 
</p>

# Noe Tovar-MBA LCARS Portfolio Dashboard

Welcome to my personal **LCARS-themed portfolio dashboard**, inspired by the iconic Star Trek computer interface. I built this 
application to serve as my daily workspace and portfolio hub — a central command console where I can quickly access my websites, 
resources, training materials, videos, and a fully functional contact form.

This project not only reflects my passion for UI/UX design inspired by sci-fi systems, but also demonstrates my experience working with 
modern web technologies and backend integrations.

---

## About This Application

I built this application to serve as a **personal Star Trek LCARS dashboard**, allowing me to:

- Manage and launch all of my commonly used websites  
- Access my books, tutorials, videos, and technical resources  
- Display system information such as CPU/RAM usage and IP address  
- Feature my latest YouTube training videos  
- Provide a working **Contact Me** form that sends messages directly to my email  
- Present my portfolio in a unique and visually striking LCARS UX

Everything on the page is live, responsive, and matches the classic LCARS color palette, layout, and animations.

---

## Technology Stack

This application was created using:

### **Frontend**
- **Blazor Web App (.NET 8)**  
- **C#**  
- **HTML / Razor Components**  
- **CSS** (custom LCARS theme, responsive grid system)  
- **JavaScript Interop** for:
  - Opening external links in new tabs  
  - Retrieving the client IP  
  - Adding audio UI sound effects  

### **Backend**
- **.NET 8**  
- **C#**  
- **SMTP email service** for backend Contact Form  
- **Dependency Injection (DI)**  
- **Configuration via appsettings.json**

### **Other Features**
- Dynamic Featured Video of the Week  
- YouTube video panels  
- LCARS resource monitor  
- Fully responsive design  
- Left/Center/Right LCARS layout  
- External links to Books, GitHub, YouTube, LinkedIn, and more  

---

## Contact Form Integration

The LCARS dashboard includes a functional **Contact Me** form.

It uses:

- C# backend service (`EmailService`)  
- Gmail SMTP (via app password)  
- Secure authentication  
- Custom async message submission  

Messages are delivered directly to:

**noetovar5@gmail.com**

---

## Project Structure

DailyDashboard/
│
├── Components/
│ ├── Layout/
│ │ └── MainLayout.razor
│ └── Pages/
│ └── Home.razor <-- LCARS Dashboard Page
│
├── Services/
│ └── EmailService.cs <-- SMTP backend
│
├── wwwroot/
│ ├── css/
│ │ └── app.css
│ └── js/
│ ├── externalLinks.js
│ └── ip.js
│
├── Program.cs
├── appsettings.json
└── DailyDashboard.csproj

---

## Features at a Glance

- ✔ LCARS UI  
- ✔ Navigation buttons  
- ✔ Free Training Tutorials  
- ✔ Dynamic video playlist  
- ✔ Featured Video of the Week  
- ✔ Resource monitor  
- ✔ Working Contact Form  
- ✔ New-tab external links  
- ✔ Clean and responsive layout  

---

## How to Run Locally

Clone the repository:

```bash
git clone https://github.com/noetovar5/star-trek-lcars-dashboard-Noe-Portfolio.git
cd star-trek-lcars-dashboard-Noe-Portfolio
dotnet restore
dotnet run
https://localhost:5138

About Me

Noe Tovar-MBA
Cloud, Linux, Digital Print, Enterprise Apps, and Technical Training Professional

Links:

🔗 https://books.tovartech.org

🔗 https://www.youtube.com/@noetovar5

🔗 https://www.linkedin.com/in/noe-tovar-mba

This project is under active development.
I will continue adding:

LCARS animations

Sound effects

Additional resource panels

System metrics

Educational modules

Backend enhancements

Feel free to explore the repository!
