namespace GeekComparer.Infrastructure.Mappers;

public class WiFiMapper : IMapper<WiFiDto, WiFi>
{
    public static WiFi ToDomain(WiFiDto dto)
        => new()
        {
            Standards = dto.Standards.Select(s => WiFiStandard.FromName(s).GetValueOrThrow())
               .ToList(),
        };

    public static WiFiDto ToDto(WiFi domain)
        => new()
        {
            Standards = domain.Standards.Select(s => s.Name).ToList(),
        };
}