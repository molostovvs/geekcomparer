using GeekComparer.Domain;

namespace GeekComparer.Web.Models;

public class SmartphoneViewModel
{
    public List<Smartphone> Smartphones { get; set; } = new();
    public List<Smartphone> Comparison { get; set; } = new();
}

public class Smartphone
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string ReleaseDate { get; set; }
}