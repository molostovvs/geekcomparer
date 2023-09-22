namespace GeekComparer.Infrastructure.Mappers;

public class RamMapper : IMapper<RamDto, Ram>
{
    public static Ram ToDomain(RamDto dto)
        => new()
        {
            Channels = dto.Channels,
            Clock = dto.Clock,
            Size = dto.Size,
            Type = RamType.FromName(dto.Type).GetValueOrThrow(),
        };

    public static RamDto ToDto(Ram domain)
        => new()
        {
            Channels = domain.Channels,
            Clock = domain.Clock,
            Size = domain.Size,
            Type = new string(domain.Type.Name),
        };
}