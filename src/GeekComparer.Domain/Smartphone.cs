namespace GeekComparer.Domain;

public class Smartphone : Entity<Guid>
{
    public string Manufacturer { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateOnly AnnounceDate { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public Battery Battery { get; set; }
    public Benchmark Benchmark { get; set; }
    public Body Body { get; set; }
    public IReadOnlyList<Camera> Cameras { get; set; }
    public Connectivity Connectivity { get; set; }
    public Memory Memory { get; set; }
    public Screen Screen { get; set; }
    public Security Security { get; set; }
    public IReadOnlyList<Sensor> Sensors { get; set; }
    public Soc Soc { get; set; }
    public Software Software { get; set; }
    public Sound Sound { get; set; }
    public MarketSegment MarketSegment { get; set; }
    public Charging Charging { get; set; }
}