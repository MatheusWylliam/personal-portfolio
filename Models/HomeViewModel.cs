namespace MatheusWylliamPortfolio.Models;

public class HomeViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string AboutText { get; set; } = string.Empty;
    public List<string> Companies { get; set; } = new();
    public List<ExperienceModel> Experiences { get; set; } = new();
    public List<SocialLinkModel> SocialLinks { get; set; } = new();
}