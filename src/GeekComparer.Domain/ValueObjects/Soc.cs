namespace GeekComparer.Domain;

public class Soc : ValueObject
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public DateOnly LaunchDate { get; set; }
    public int Litography { get; set; }
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Manufacturer;
        yield return Model;
        yield return LaunchDate;
        yield return Litography;
        yield return Cpu;
        yield return Gpu;
    }
}