namespace GeekComparer.Infrastructure.Mappers;

public class BatteryMapper : IMapper<BatteryDto, Battery>
{
    public static Battery ToDomain(BatteryDto dto)
        => new()
        {
            Capacity = dto.Capacity,
            Life = BatteryLifeMapper.ToDomain(dto.Life),
            Replaceable = dto.Replaceable,
            Type = BatteryType.FromName(dto.Type).GetValueOrThrow(),
        };

    public static BatteryDto ToDto(Battery domain)
        => new()
        {
            Capacity = domain.Capacity,
            Life = BatteryLifeMapper.ToDto(domain.Life),
            Replaceable = domain.Replaceable,
            Type = domain.Type.Name,
        };
}