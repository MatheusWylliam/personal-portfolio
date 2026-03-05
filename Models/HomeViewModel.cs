namespace MatheusWylliamPortfolio.Models;

public class HomeViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string AboutText { get; set; } = string.Empty;
    public string Lang { get; set; } = "pt";
    public UiLabels Labels { get; set; } = new();
    public List<ExperienceModel> Experiences { get; set; } = new();
    public List<SocialLinkModel> SocialLinks { get; set; } = new();
}

public class UiLabels
{
    public string Hello { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string NavStart { get; set; } = string.Empty;
    public string NavAbout { get; set; } = string.Empty;
    public string NavExperience { get; set; } = string.Empty;
    public string NavProjects { get; set; } = string.Empty;
    public string NavStack { get; set; } = string.Empty;
    public string SectionAbout { get; set; } = string.Empty;
    public string SectionExperience { get; set; } = string.Empty;
    public string SectionProjects { get; set; } = string.Empty;
    public string SectionStack { get; set; } = string.Empty;
    public string ComingSoon { get; set; } = string.Empty;
    public string AboutBody { get; set; } = string.Empty;
    public string FooterText { get; set; } = string.Empty;
}