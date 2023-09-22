namespace GeekComparer.Infrastructure.Mappers;

public class BenchmarkMapper : IMapper<BenchmarkDto, Benchmark>
{
    public static Benchmark ToDomain(BenchmarkDto dto)
        => new()
        {
            Antutu = AntutuBenchmarkMapper.ToDomain(dto.Antutu),
            DxOMark = DxOMarkBenchmarkMapper.ToDomain(dto.DxOMark),
            Geekbench5 = GeekbenchBenchmarkMapper.ToDomain(dto.Geekbench5),
            ThreeDMark = ThreeDMarkBenchmarkMapper.ToDomain(dto.ThreeDMark),
        };

    public static BenchmarkDto ToDto(Benchmark domain)
        => new()
        {
            Antutu = AntutuBenchmarkMapper.ToDto(domain.Antutu),
            DxOMark = DxOMarkBenchmarkMapper.ToDto(domain.DxOMark),
            Geekbench5 = GeekbenchBenchmarkMapper.ToDto(domain.Geekbench5),
            ThreeDMark = ThreeDMarkBenchmarkMapper.ToDto(domain.ThreeDMark),
        };
}