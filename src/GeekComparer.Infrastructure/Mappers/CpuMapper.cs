namespace GeekComparer.Infrastructure.Mappers;

public class CpuMapper : IMapper<CpuDto, Cpu>
{
    public static Cpu ToDomain(CpuDto dto)
        => new()
        {
            Cores = dto.Cores.Select(c => CoreMapper.ToDomain(c)).ToList(),
            Tdp = dto.Tdp,
        };

    public static CpuDto ToDto(Cpu domain)
        => new()
        {
            Cores = domain.Cores.Select(c => CoreMapper.ToDto(c)).ToList(),
            Tdp = domain.Tdp,
        };
}