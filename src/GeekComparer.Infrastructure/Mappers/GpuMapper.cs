namespace GeekComparer.Infrastructure.Mappers;

public class GpuMapper : IMapper<GpuDto, Gpu>
{
    public static Gpu ToDomain(GpuDto dto)
        => new()
        {
            MaxClock = dto.MaxClock,
            Model = dto.Model,
        };

    public static GpuDto ToDto(Gpu domain)
        => new()
        {
            MaxClock = domain.MaxClock,
            Model = domain.Model,
        };
}