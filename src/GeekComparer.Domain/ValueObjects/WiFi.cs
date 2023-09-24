namespace GeekComparer.Domain.ValueObjects;

public class WiFi : ValueObject
{
    public IReadOnlyList<WiFiStandard> Standards { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => Standards;
}