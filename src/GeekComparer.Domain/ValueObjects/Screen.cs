namespace GeekComparer.Domain.ValueObjects;

public class Screen : ValueObject
{
    public ScreenMatriceTechnology ScreenMatriceTechnology { get; set; }
    public double Size { get; set; }
    public int WidthInPixels { get; set; }
    public int HeightInPixels { get; set; }
    public double AspectRatio { get; set; } //TODO: calculate it
    public int MinRefreshRatio { get; set; }
    public int MaxRefreshRatio { get; set; }
    public int MaxBrightness { get; set; }
    public int HDRBrightness { get; set; }
    public bool HDRSupport { get; set; }
    public HdrFormat HDRFormat { get; set; }
    public bool HasDCDimming { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return ScreenMatriceTechnology;
        yield return Size;
        yield return WidthInPixels;
        yield return HeightInPixels;
        yield return AspectRatio;
        yield return MinRefreshRatio;
        yield return MaxRefreshRatio;
        yield return MaxBrightness;
        yield return HDRBrightness;
        yield return HDRSupport;
        yield return HDRFormat;
        yield return HasDCDimming;
    }
}