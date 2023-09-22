namespace GeekComparer.Infrastructure.DTOs;

public class SmartphoneDto
{
    public Guid Id { get; set; }
    public string Manufacturer { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateOnly AnnounceDate { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public BatteryDto Battery { get; set; }
    public BenchmarkDto Benchmark { get; set; }
    public BodyDto Body { get; set; }
    public List<CameraDto> Cameras { get; set; }
    public ConnectivityDto Connectivity { get; set; }
    public MemoryDto Memory { get; set; }
    public ScreenDto Screen { get; set; }
    public SecurityDto Security { get; set; }
    public List<string> Sensors { get; set; }
    public SocDto Soc { get; set; }
    public SoftwareDto Software { get; set; }
    public SoundDto Sound { get; set; }
    public string MarketSegment { get; set; }
    public ChargingDto Charging { get; set; }
}