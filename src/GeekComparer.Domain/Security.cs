namespace GeekComparer.Domain;

public class Security : ValueObject
{
    public bool HasFaceUnlock { get; set; }
    public bool HasFingerprintUnlock { get; set; }
    public bool HasIrisUnlock { get; set; }  // eye
    public bool HasCoprocessor { get; set; } //like Titan chip in google pixel

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return HasFaceUnlock;
        yield return HasFingerprintUnlock;
        yield return HasIrisUnlock;
        yield return HasCoprocessor;
    }
}