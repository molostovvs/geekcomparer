namespace GeekComparer.Infrastructure.DTOs;

public class ScreenDto
{
    public string MatriceTechnology { get; set; }
    public double Size { get; set; }
    public int WidthInPixels { get; set; }
    public int HeightInPixels { get; set; }
    public double AspectRatio { get; set; }
    public int MinRefreshRatio { get; set; }
    public int MaxRefreshRatio { get; set; }
    public int MaxBrightness { get; set; }
    public int HdrBrightness { get; set; }
    public bool HdrSupport { get; set; }
    public string HdrFormat { get; set; }
    public bool HasDcDimming { get; set; }
}