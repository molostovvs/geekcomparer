using GeekComparer.Domain;

namespace GeekComparer.Web.ViewModels;

public class SmartphonesViewModel
{
    public Smartphone? Choosen { get; set; }
    public List<Smartphone> NotCompared { get; set; } = new();
    public List<Smartphone> Compared { get; set; } = new();
}