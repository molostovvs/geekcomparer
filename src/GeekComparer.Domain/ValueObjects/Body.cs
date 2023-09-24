namespace GeekComparer.Domain.ValueObjects;

public class Body : ValueObject
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
    public string IpRating { get; set; }
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
        yield return IpRating;
        yield return ScreenProtection;
        yield return FrameMaterial;
        yield return BackMaterial;
        yield return Color;
        yield return FingerprintLocation;
    }
}