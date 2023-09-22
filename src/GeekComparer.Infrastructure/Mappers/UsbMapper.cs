namespace GeekComparer.Infrastructure.Mappers;

public class UsbMapper : IMapper<UsbDto, Usb>
{
    public static Usb ToDomain(UsbDto dto)
        => new()
        {
            Connector = UsbConnector.FromName(dto.Connector).GetValueOrThrow(),
            Version = new string(dto.Version),
            Features = dto.Features.Select(f => UsbFeature.FromName(f).GetValueOrThrow()).ToList(),
        };

    public static UsbDto ToDto(Usb domain)
        => new()
        {
            Connector = domain.Connector.Name,
            Version = new string(domain.Version),
            Features = domain.Features.Select(f => f.Name).ToList(),
        };
}