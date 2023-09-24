namespace GeekComparer.Domain.ValueObjects;

public class Battery : ValueObject
{
    public int Capacity { get; set; }
    public BatteryType Type { get; set; }
    public bool Replaceable { get; set; }
    public BatteryLife Life { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Capacity;
        yield return Type;
        yield return Replaceable;
        yield return Life;
    }
}