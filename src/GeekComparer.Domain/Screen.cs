namespace GeekComparer.Domain;

public class Screen : ValueObject
{
    public DisplayType Type { get; set; }
    public double Size { get; set; }
    public int WidthInPixels { get; set; }
    public int HeightInPixels { get; set; }
    public int AspectRatio => HeightInPixels / WidthInPixels; //TODO:
    public int MinRefreshRatio { get; set; }
    public int MaxRefreshRatio { get; set; }
    public int TypicalBrightness { get; set; } //TODO: should it be called MaxBrightness?
    public int MaxBrightness { get; set; }     //TODO: shouild it be called MaxHDRBrightness?
    public bool HDRSupport { get; set; }
    public string HDRType { get; set; }
    public string Protection { get; set; }
    public bool AlwaysOnDisplaySupported { get; set; }
    public bool DCDimmingSupported { get; set; }
    public bool DCIP3Supported { get; set; } //TODO: check other color features
    public int PMW { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public enum DisplayType
{
    AMOLED, IPS, OLED
}