namespace GeekComparer.Domain.ValueObjects;

public class Cellular : ValueObject
{
    public int SimCount { get; set; }
    public IReadOnlyList<SimFormat> SimType { get; set; }
    public MultiSimMode MultiSimMode { get; set; }
    public IReadOnlyList<TwoGBand> Bands2G { get; set; }
    public IReadOnlyList<ThreeGBand> Bands3G { get; set; }
    public IReadOnlyList<FourGBand> Bands4G { get; set; }
    public IReadOnlyList<FiveGBand> Bands5G { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SimCount;
        foreach (var simType in SimType)
            yield return simType;
        yield return MultiSimMode;

        foreach (var s in Bands2G)
            yield return s;

        foreach (var s in Bands3G)
            yield return s;

        foreach (var s in Bands4G)
            yield return s;

        foreach (var s in Bands5G)
            yield return s;
    }
}