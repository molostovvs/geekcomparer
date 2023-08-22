namespace GeekComparer.Domain;

public class Body : ValueObject
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
    public string IPRating { get; set; } // 6X or 68 or 5X
    public string ScreenProtection { get; set; }
    public Material FrameMaterial { get; set; }
    public Material BackMaterial { get; set; }
    public string Color { get; set; }
    public FingerprintLocation FingerprintLocation { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Height;
        yield return Width;
        yield return Thickness;
        yield return Weight;
        yield return IPRating;
        yield return ScreenProtection;
        yield return FrameMaterial;
        yield return BackMaterial;
        yield return Color;
        yield return FingerprintLocation;
    }
}

public class FingerprintLocation : EnumValueObject<FingerprintLocation, int>
{
    public static readonly FingerprintLocation Screen = new(1, nameof(Screen));
    public static readonly FingerprintLocation Button = new(2, nameof(Button));
    public static readonly FingerprintLocation Side = new(3, nameof(Side));
    public static readonly FingerprintLocation Back = new(4, nameof(Back));

    private FingerprintLocation(int id, string name) : base(id, name) {}
}

public class Material : EnumValueObject<Material, int>
{
    public static readonly Material Metal = new(1, nameof(Metal));
    public static readonly Material Glass = new(2, nameof(Glass));
    public static readonly Material Plastic = new(3, nameof(Plastic));
    public static readonly Material Carbon = new(4, nameof(Carbon));
    public static readonly Material Ceramic = new(5, nameof(Ceramic));

    private Material(int id, string name) : base(id, name) {}
}