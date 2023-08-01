namespace GeekComparer.Domain;

public class Body : ValueObject
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
    public string Protection { get; set; } //TODO: Rename to IPRating?
    public Material FrameMaterial { get; set; }
    public Material BackMaterial { get; set; }
    public IReadOnlyList<string> ColorsAvailable { get; set; }
    public FingerprintLocation FingerprintLocation { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public enum FingerprintLocation
{
    Screen, Button, Side, Back, None,
}

public enum Material
{
    Metal, Glass, Plastic, Carbon,
}