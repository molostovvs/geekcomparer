namespace GeekComparer.Infrastructure.Mappers;

public class ConnectivityMapper : IMapper<ConnectivityDto, Connectivity>
{
    public static Connectivity ToDomain(ConnectivityDto dto)
        => new()
        {
            Bluetooth = BluetoothMapper.ToDomain(dto.Bluetooth),
            Cellular = CellularMapper.ToDomain(dto.Cellular),
            NavigationSystems = dto.NavigationSystems
               .Select(ns => NavigationSystem.FromName(ns).GetValueOrThrow())
               .ToList(),
            WiFi = WiFiMapper.ToDomain(dto.WiFi),
            Usb = UsbMapper.ToDomain(dto.Usb),
            HasIR = dto.HasIR,
            HasNFC = dto.HasNFC,
            HasUWB = dto.HasUWB,
        };

    public static ConnectivityDto ToDto(Connectivity domain)
        => new()
        {
            Bluetooth = BluetoothMapper.ToDto(domain.Bluetooth),
            Cellular = CellularMapper.ToDto(domain.Cellular),
            NavigationSystems = domain.NavigationSystems
               .Select(ns => ns.Name)
               .ToList(),
            WiFi = WiFiMapper.ToDto(domain.WiFi),
            Usb = UsbMapper.ToDto(domain.Usb),
            HasIR = domain.HasIR,
            HasNFC = domain.HasNFC,
            HasUWB = domain.HasUWB,
        };
}