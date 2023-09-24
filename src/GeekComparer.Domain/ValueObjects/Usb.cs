namespace GeekComparer.Domain.ValueObjects;

public class Usb : ValueObject
{
    public string Version { get; set; }
    public UsbConnector Connector { get; set; }
    public IReadOnlyList<UsbFeature> Features { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Version;
        yield return Connector;

        foreach (var feature in Features)
            yield return feature;
    }
}