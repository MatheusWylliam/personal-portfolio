using MatheusWylliamPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace MatheusWylliamPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string lang = "pt")
    {
        var isPt = lang != "en";

        var experiences = new List<ExperienceModel>
        {
            new ExperienceModel
            {
                Company = "LIGA Norte Contra o Câncer",
                Role = "Data Analyst",
                Period = isPt ? "FEV 2024 - PRESENTE" : "FEB 2024 - PRESENT",
                Bullets = isPt
                    ? new List<string>
                    {
                        "Desenvolvi a aplicação institucional de gestão de dados com ASP.NET Core MVC (C#), responsável por exportações, construção de indicadores estratégicos e gerenciamento de dashboards corporativos.",
                        "Arquitetura Lakehouse (Datalake + Data Warehouse), modelagem e transformação de dados com R e Python.",
                        "Orquestração de pipelines ELT/ETL com Apache Airflow e uso de Docker para padronização de ambientes.",
                        "Engenharia de dados em ambiente hospitalar oncológico, processando grandes volumes de dados clínicos e assistenciais."
                    }
                    : new List<string>
                    {
                        "Development and maintenance of the institutional data management platform using ASP.NET Core MVC (C#), responsible for data exports, KPI construction, and corporate dashboard management.",
                        "Lakehouse architecture (Datalake + Data Warehouse), data modeling and transformation using R and Python.",
                        "ELT/ETL pipeline orchestration with Apache Airflow and use of Docker for environment standardization.",
                        "Data engineering in an oncology hospital environment, processing large volumes of clinical and healthcare data."
                    }
            },
            new ExperienceModel
            {
                Company = "IFRN - Instituto Federal",
                Role = isPt ? "Estagiário TI — Ênfase em Eletrônica" : "IT Intern — Electronics Focus",
                Period = "JAN 2021 - JAN 2022",
                Bullets = isPt
                    ? new List<string>
                    {
                        "Desenvolvi projetos de automação utilizando Arduino e C++, aplicados ao monitoramento de sistemas físicos do campus.",
                        "Implementei circuitos de controle e aquisição de dados com sensores (temperatura, umidade, presença) integrados a microcontroladores.",
                        "Criei soluções embarcadas para coleta e transmissão de dados de sensores via protocolos seriais (UART, I2C, SPI).",
                        "Realizei manutenção e diagnóstico de equipamentos eletrônicos e infraestrutura de laboratório.",
                        "Documentei projetos técnicos e procedimentos operacionais para o setor de TI do instituto."
                    }
                    : new List<string>
                    {
                        "Developed automation projects using Arduino and C++, applied to campus physical system monitoring.",
                        "Implemented control and data acquisition circuits with sensors (temperature, humidity, presence) integrated with microcontrollers.",
                        "Built embedded solutions for sensor data collection and transmission via serial protocols (UART, I2C, SPI).",
                        "Performed maintenance and diagnostics of electronic equipment and laboratory infrastructure.",
                        "Documented technical projects and operational procedures for the institute's IT department."
                    }
            }
        };

        var aboutPt =
            "Software Developer (PUC), Data Scientist (UFRN) e Técnico em Eletrônica (IFRN) com foco em .NET (C#, VB), desenvolvimento ASP.NET, machine learning e data engineering. Expertise em arquitetura de software com CQRS e MVC, pipelines de dados, APIs RESTful, modelos de machine learning com ênfase em MLOps e arquitetura de dados. Graduando em Análise e Desenvolvimento de Sistemas (PUC) e Ciência de Dados (UFRN).";

        var aboutEn =
            "Software Developer (PUC), Data Scientist (UFRN) and Electronics Technician (IFRN) focused on .NET (C#, VB), ASP.NET development, machine learning and data engineering. Expertise in software architecture with CQRS and MVC, data pipelines, RESTful APIs, machine learning models with emphasis on MLOps, and data architecture. Undergraduate student in Systems Analysis and Development (PUC) and Data Science (UFRN).";

        var labels = isPt
            ? new UiLabels
            {
                Hello = "Eai, eu sou o",
                Headline = "Cientista de Dados & Desenvolvedor .NET",
                NavStart = "Início",
                NavAbout = "Sobre",
                NavExperience = "Experiência",
                NavProjects = "Projetos",
                NavStack = "Stacks",
                SectionAbout = "Sobre mim",
                SectionExperience = "Experiência",
                SectionProjects = "Projetos",
                SectionStack = "Stacks",
                ComingSoon = "Em breve",
                AboutBody = aboutPt,
                FooterText = "© 2026 Matheus Wylliam. All rights reserved.|Develop with ASP.NET Core and Tailwind CSS 3."
            }
            : new UiLabels
            {
                Hello = "Hey, I'm",
                Headline = "Data Scientist & .NET Developer · Brazil",
                NavStart = "Home",
                NavAbout = "About",
                NavExperience = "Experience",
                NavProjects = "Projects",
                NavStack = "Stacks",
                SectionAbout = "About me",
                SectionExperience = "Experience",
                SectionProjects = "Projects",
                SectionStack = "Stacks",
                ComingSoon = "Coming soon",
                AboutBody = aboutEn,
                FooterText = "© 2026 Matheus Wylliam. All rights reserved.|Develop with ASP.NET Core and Tailwind CSS 3."
            };

        var model = new HomeViewModel
        {
            Name = "Matheus Wylliam",
            Lang = isPt ? "pt" : "en",
            Labels = labels,
            Experiences = experiences,
            SocialLinks = new List<SocialLinkModel>
            {
                new SocialLinkModel { Label = "GitHub", Url = "https://github.com/MatheusWylliam", HoverColor = "yellow" },
                new SocialLinkModel { Label = "LinkedIn", Url = "", HoverColor = "blue" }
            }
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}