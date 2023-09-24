namespace GeekComparer.Domain.ValueObjects;

public class PhotoCapabilities : ValueObject
{
    public int MaxWidth { get; set; }
    public int MaxHeight { get; set; }
    public string MaxResolution => MaxHeight + " x " + MaxWidth;

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return MaxWidth;
        yield return MaxHeight;
        yield return MaxResolution;
    }
}