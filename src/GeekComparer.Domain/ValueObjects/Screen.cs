namespace GeekComparer.Domain.ValueObjects;

public class Screen : ValueObject
{
    public ScreenMatriceTechnology MatriceTechnology { get; set; }
    public double Size { get; set; }
    public int WidthInPixels { get; set; }
    public int HeightInPixels { get; set; }
    public double AspectRatio { get; set; } //TODO: calculate it
    public int MinRefreshRatio { get; set; }
    public int MaxRefreshRatio { get; set; }
    public int MaxBrightness { get; set; }
    public int HdrBrightness { get; set; }
    public bool HdrSupport { get; set; }
    public HdrFormat HdrFormat { get; set; }
    public bool HasDcDimming { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return MatriceTechnology;
        yield return Size;
        yield return WidthInPixels;
        yield return HeightInPixels;
        yield return AspectRatio;
        yield return MinRefreshRatio;
        yield return MaxRefreshRatio;
        yield return MaxBrightness;
        yield return HdrBrightness;
        yield return HdrSupport;
        yield return HdrFormat;
        yield return HasDcDimming;
    }
}