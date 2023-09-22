namespace GeekComparer.Infrastructure.Mappers;

public class AntutuBenchmarkMapper : IMapper<AntutuBenchmarkDto, AntutuBenchmark>
{
    public static AntutuBenchmark ToDomain(AntutuBenchmarkDto dto)
        => new()
        {
            Cpu = dto.Cpu,
            Gpu = dto.Gpu,
            Mem = dto.Mem,
            Ux = dto.Ux,
            Total = dto.Total,
        };

    public static AntutuBenchmarkDto ToDto(AntutuBenchmark domain)
        => new()
        {
            Cpu = domain.Cpu,
            Gpu = domain.Gpu,
            Mem = domain.Mem,
            Ux = domain.Ux,
            Total = domain.Total,
        };
}