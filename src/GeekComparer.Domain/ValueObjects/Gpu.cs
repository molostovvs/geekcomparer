namespace GeekComparer.Domain.ValueObjects;

public class Gpu : ValueObject
{
    public string Model { get; set; }
    public int MaxClock { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Model;
        yield return MaxClock;
    }
}