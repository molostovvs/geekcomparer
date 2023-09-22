namespace GeekComparer.Infrastructure.Mappers;

public class BatteryLifeMapper : IMapper<BatteryLifeDto, BatteryLife>
{
    public static BatteryLife ToDomain(BatteryLifeDto dto)
        => new()
        {
            Gaming = dto.Gaming,
            Standby = dto.Standby,
            Video = dto.Video,
            WebBrowsing = dto.WebBrowsing,
        };

    public static BatteryLifeDto ToDto(BatteryLife domain)
        => new()
        {
            Gaming = domain.Gaming.GetValueOrThrow(),
            Standby = domain.Standby.GetValueOrThrow(),
            Video = domain.Video.GetValueOrThrow(),
            WebBrowsing = domain.WebBrowsing.GetValueOrThrow(),
        };
}