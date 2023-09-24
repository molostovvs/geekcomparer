namespace GeekComparer.Domain.ValueObjects;

public class Ram : ValueObject
{
    public int Size { get; set; }
    public RamType Type { get; set; }
    public int Clock { get; set; }
    public int Channels { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Size;
        yield return Type;
        yield return Clock;
        yield return Channels;
    }
}