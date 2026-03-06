# Personal Portfolio

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-8.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind_CSS-3.4-06B6D4?style=flat-square&logo=tailwindcss&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat-square&logo=docker&logoColor=white)
![Node.js](https://img.shields.io/badge/Node.js-20-339933?style=flat-square&logo=nodedotjs&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow?style=flat-square)

Personal portfolio built with **ASP.NET Core MVC (.NET 8)** and **Tailwind CSS 3**, fully containerized with Docker using a 3-stage multi-stage build targeting Alpine Linux for a minimal, production-ready image.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC 8 |
| Language | C# 12 |
| Styling | Tailwind CSS 3.4 |
| CSS Processing | PostCSS 8, Autoprefixer |
| Runtime | .NET 8 Alpine |
| Containerization | Docker, Docker Compose V2 |

---

## Project Structure

```
portfolio/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── ErrorViewModel.cs
│   ├── ExperienceModel.cs
│   ├── HomeViewModel.cs
│   └── SocialLinkModel.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── Error.cshtml
├── wwwroot/
│   ├── css/
│   │   └── input.css
│   ├── icons/
│   ├── images/
│   └── js/
│       └── site.js
├── Dockerfile
├── docker-compose.yml
├── .dockerignore
├── tailwind.config.js
├── postcss.config.js
└── Program.cs
```

---

## Docker Architecture

3-stage multi-stage build targeting `alpine` at every stage to minimize final image size (~120MB).

| Stage | Base Image | Responsibility |
|---|---|---|
| `tailwind-build` | `node:20-alpine` | Installs npm dependencies, compiles and minifies Tailwind CSS |
| `dotnet-build` | `mcr.microsoft.com/dotnet/sdk:8.0-alpine` | Restores NuGet packages, publishes Release build |
| `final` | `mcr.microsoft.com/dotnet/aspnet:8.0-alpine` | Runtime only — no SDK, no Node, runs as non-root user |

---

## Prerequisites

| Tool | Version |
|---|---|
| .NET SDK | 8.0+ |
| Node.js | 20+ |
| Docker | 24+ |
| Docker Compose | V2 |

---

## Running Locally

```bash
git clone https://github.com/MatheusWylliam/personal-portfolio
cd personal-portfolio
npm ci
npm run tw:build
dotnet run
```

Access at `http://localhost:5013`

Watch mode for Tailwind during development:

```bash
npm run tw:watch
```

---

## Running with Docker

```bash
git clone https://github.com/MatheusWylliam/personal-portfolio
cd personal-portfolio
docker compose up --build
```

Access at `http://localhost:8080`

```bash
docker compose down
docker compose logs -f
docker compose ps
```

---

## Environment Variables

| Variable | Default | Description |
|---|---|---|
| `ASPNETCORE_ENVIRONMENT` | `Production` | ASP.NET Core environment |
| `ASPNETCORE_URLS` | `http://+:8080` | Binding address inside the container |

---

## License

This project is licensed under the [MIT License](LICENSE).

---

<p align="center">Built with ASP.NET Core and Tailwind CSS by <a href="https://github.com/MatheusWylliam">Matheus Wylliam</a></p>
