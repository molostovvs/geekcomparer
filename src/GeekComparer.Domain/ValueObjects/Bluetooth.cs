namespace GeekComparer.Domain.ValueObjects;

public class Bluetooth : ValueObject
{
    public string Version { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Version;
    }
}