namespace GeekComparer.Infrastructure.Mappers;

public class SocMapper : IMapper<SocDto, Soc>
{
    public static Soc ToDomain(SocDto dto)
        => new()
        {
            Cpu = CpuMapper.ToDomain(dto.Cpu),
            Gpu = GpuMapper.ToDomain(dto.Gpu),
            LaunchDate = dto.LaunchDate,
            Litography = dto.Litography,
            Manufacturer = new string(dto.Manufacturer),
            Model = new string(dto.Model),
        };

    public static SocDto ToDto(Soc domain)
        => new()
        {
            Cpu = CpuMapper.ToDto(domain.Cpu),
            Gpu = GpuMapper.ToDto(domain.Gpu),
            LaunchDate = domain.LaunchDate,
            Litography = domain.Litography,
            Manufacturer = new string(domain.Manufacturer),
            Model = new string(domain.Model),
        };
}