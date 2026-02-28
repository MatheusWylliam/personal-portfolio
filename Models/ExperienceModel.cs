namespace MatheusWylliamPortfolio.Models;

public class ExperienceModel
{
    public string Company { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public List<string> Bullets { get; set; } = new();
}