namespace GeekComparer.Domain;

public class Screen : ValueObject
{
    public Panel Panel { get; set; }
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
        yield return HasDCDimming;
    }
}

public class HdrFormat : EnumValueObject<HdrFormat, int>
{
    public static readonly HdrFormat HDR10 = new(1, nameof(HDR10));
    public static readonly HdrFormat DolbyVision = new(2, nameof(DolbyVision));
    public static readonly HdrFormat HDR10Plus = new(3, nameof(HDR10Plus));
    public static readonly HdrFormat HLG = new(4, nameof(HLG));

    private HdrFormat(int id, string name) : base(id, name) {}
}

public class Panel : EnumValueObject<Panel, int>
{
    public static readonly Panel IPS = new(1, nameof(IPS));
    public static readonly Panel OLED = new(2, nameof(OLED));
    public static readonly Panel EInk = new(3, nameof(EInk));

    private Panel(int id, string name) : base(id, name) {}
}