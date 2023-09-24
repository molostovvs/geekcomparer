namespace GeekComparer.Domain.ValueObjects;

public class Connectivity : ValueObject
{
    public Cellular Cellular { get; set; }
    public WiFi WiFi { get; set; }
    public Bluetooth Bluetooth { get; set; }
    public IReadOnlyList<NavigationSystem> NavigationSystems { get; set; }
    public Usb USB { get; set; }
    public bool HasNFC { get; set; }
    public bool HasIR { get; set; }
    public bool HasUWB { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Cellular;
        yield return WiFi;
        yield return Bluetooth;

        foreach (var ns in NavigationSystems)
            yield return ns;

        yield return USB;
    }
}