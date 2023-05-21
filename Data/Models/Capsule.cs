namespace Capsules.Data.Models;

public class Capsule
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public decimal Rating { get; set; }
    public int Intensity { get; set; }
    public string Notes { get; set; }
    public string Profiles { get; set; }
}
