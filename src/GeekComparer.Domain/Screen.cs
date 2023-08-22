namespace GeekComparer.Domain;

public class Screen : ValueObject
{
    public Panel Panel { get; set; }
    public double Size { get; set; }
    public int WidthInPixels { get; set; }
    public int HeightInPixels { get; set; }
    public int AspectRatio { get; set; } //TODO: calculate it
    public int MinRefreshRatio { get; set; }
    public int MaxRefreshRatio { get; set; }
    public int MaxBrightness { get; set; }
    public int HDRBrightness { get; set; }
    public bool HDRSupport { get; set; }
    public HDRFormat HDRFormat { get; set; }
    public string Protection { get; set; } //convert to Enum?
    public bool HasDCDimming { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Panel;
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
        yield return Protection;
        yield return HasDCDimming;
    }
}

public class HDRFormat : EnumValueObject<HDRFormat, int>
{
    public static readonly HDRFormat HDR10 = new(1, nameof(HDR10));
    public static readonly HDRFormat DolbyVision = new(2, nameof(DolbyVision));
    public static readonly HDRFormat HDR10Plus = new(3, nameof(HDR10Plus));
    public static readonly HDRFormat HLG = new(4, nameof(HLG));

    private HDRFormat(int id, string name) : base(id, name) {}
}

public class Panel : EnumValueObject<Panel, int>
{
    public static readonly Panel IPS = new(1, nameof(IPS));
    public static readonly Panel OLED = new(2, nameof(OLED));

    private Panel(int id, string name) : base(id, name) {}
}