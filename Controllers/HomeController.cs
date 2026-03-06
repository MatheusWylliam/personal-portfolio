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
            },
            new ExperienceModel
            {
                Company = "AFS - Intercultural Programs",
                Role = isPt ? "Intérprete de Inglês" : "Volunteer English Interpreter",
                Period = "FEV 2019 - DEZ 2022",
                Bullets = isPt
                    ? new List<string>
                    {
                        "Atuei como intérprete voluntário de inglês, facilitando a comunicação entre intercambistas de diferentes países e a comunidade local em eventos, reuniões e atividades culturais.",
                        "Realizei apresentações técnicas na área de Eletrônica para grupos internacionais, traduzindo conceitos complexos de forma clara e acessível para públicos de diferentes idiomas e culturas.",
                        "Auxiliei intercambistas no processo de adaptação cultural, oferecendo suporte linguístico e orientação em situações cotidianas, acadêmicas e institucionais.",
                        "Desenvolvi habilidades sólidas de comunicação intercultural, oratória e liderança ao mediar experiências entre jovens de múltiplas nacionalidades.",
                        "Colaborei na organização de eventos e atividades do programa, contribuindo para a integração e o enriquecimento cultural dos participantes."
                    }
                    : new List<string>
                    {
                        "Served as a volunteer English interpreter, facilitating communication between exchange students from different countries and the local community at events, meetings, and cultural activities.",
                        "Delivered technical presentations in the field of Electronics to international groups, translating complex concepts clearly and accessibly for audiences of different languages and backgrounds.",
                        "Supported exchange students through cultural adaptation, providing linguistic assistance and guidance in everyday, academic, and institutional situations.",
                        "Developed strong intercultural communication, public speaking, and leadership skills by mediating experiences among young people from multiple nationalities.",
                        "Collaborated in the organization of program events and activities, contributing to the integration and cultural enrichment of participants."
                    }
            }
        };

        var aboutPt =
            "Software Developer (PUC), Data Scientist (UFRN) e Técnico em Eletrônica (IFRN) com foco em .NET (C#, VB), desenvolvimento ASP.NET Core, machine learning e data engineering. Expertise em arquitetura de software com CQRS e MVC, pipelines de dados, APIs RESTful, modelos de machine learning com ênfase em MLOps e arquitetura de dados. Graduando em Análise e Desenvolvimento de Sistemas (PUC) e Ciência de Dados (UFRN).<br><br>Português Nativo | Inglês Avançado (C1).";

        var aboutEn =
            "Software Developer (PUC), Data Scientist (UFRN) and Electronics Technician (IFRN) focused on .NET (C#, VB), ASP.NET Core development, machine learning and data engineering. Expertise in software architecture with CQRS and MVC, data pipelines, RESTful APIs, machine learning models with emphasis on MLOps, and data architecture. Undergraduate student in Systems Analysis and Development (PUC) and Data Science (UFRN).<br><br>Native Portuguese | Advanced English (C1).";

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