using GeekComparer.Infrastructure.DTOs;

namespace GeekComparer.Web.ViewModels;

public class SmartphonesViewModel
{
    public List<string> NotCompared { get; set; } = new();
    public List<SmartphoneDto> Compared { get; set; } = new();
}