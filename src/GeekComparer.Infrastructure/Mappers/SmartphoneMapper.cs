using System.Reflection;
using Microsoft.Win32.SafeHandles;

namespace GeekComparer.Infrastructure.Mappers;

public class SmartphoneMapper : IMapper<SmartphoneDto, Smartphone>
{
    public static Smartphone ToDomain(SmartphoneDto dto)
    {
        var sm = new Smartphone()
        {
            Manufacturer = new string(dto.Manufacturer),
            Brand = new string(dto.Brand),
            Model = new string(dto.Model),
            AnnounceDate = dto.AnnounceDate,
            ReleaseDate = dto.ReleaseDate,
            Battery = BatteryMapper.ToDomain(dto.Battery),
            Benchmark = BenchmarkMapper.ToDomain(dto.Benchmark),
            Body = BodyMapper.ToDomain(dto.Body),
            Cameras = dto.Cameras.Select(CameraMapper.ToDomain).ToList(),
            Connectivity = ConnectivityMapper.ToDomain(dto.Connectivity),
            Memory = MemoryMapper.ToDomain(dto.Memory),
            Screen = ScreenMapper.ToDomain(dto.Screen),
            Security = SecurityMapper.ToDomain(dto.Security),
            Sensors = dto.Sensors.Select(s => Sensor.FromName(s).GetValueOrThrow()).ToList(),
            Soc = SocMapper.ToDomain(dto.Soc),
            Software = SoftwareMapper.ToDomain(dto.Software),
            Sound = SoundMapper.ToDomain(dto.Sound),
            MarketSegment = MarketSegment.FromName(dto.MarketSegment).GetValueOrThrow(),
            Charging = ChargingMapper.ToDomain(dto.Charging),
        };

        sm.GetType()
           .GetProperty("Id", BindingFlags.Instance | BindingFlags.NonPublic)
          ?.SetValue(sm, dto.Id);

        return sm;
    }

    public static SmartphoneDto ToDto(Smartphone domain)
        => new()
        {
            Id = domain.Id,
            Manufacturer = new string(domain.Manufacturer),
            Brand = new string(domain.Brand),
            Model = new string(domain.Model),
            AnnounceDate = domain.AnnounceDate,
            ReleaseDate = domain.ReleaseDate,
            Battery = BatteryMapper.ToDto(domain.Battery),
            Benchmark = BenchmarkMapper.ToDto(domain.Benchmark),
            Body = BodyMapper.ToDto(domain.Body),
            Cameras = domain.Cameras.Select(CameraMapper.ToDto).ToList(),
            Connectivity = ConnectivityMapper.ToDto(domain.Connectivity),
            Memory = MemoryMapper.ToDto(domain.Memory),
            Screen = ScreenMapper.ToDto(domain.Screen),
            Security = SecurityMapper.ToDto(domain.Security),
            Sensors = domain.Sensors.Select(s => s.Name).ToList(),
            Soc = SocMapper.ToDto(domain.Soc),
            Software = SoftwareMapper.ToDto(domain.Software),
            Sound = SoundMapper.ToDto(domain.Sound),
            MarketSegment = domain.MarketSegment.Name,
            Charging = ChargingMapper.ToDto(domain.Charging),
        };
}