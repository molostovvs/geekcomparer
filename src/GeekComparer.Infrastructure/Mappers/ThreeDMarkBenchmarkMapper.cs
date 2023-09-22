namespace GeekComparer.Infrastructure.Mappers;

public class ThreeDMarkBenchmarkMapper : IMapper<ThreeDMarkBenchmarkDto, ThreeDMarkBenchmark>
{
    public static ThreeDMarkBenchmark ToDomain(ThreeDMarkBenchmarkDto dto)
        => new()
        {
            Performance = dto.Performance,
        };

    public static ThreeDMarkBenchmarkDto ToDto(ThreeDMarkBenchmark domain)
        => new()
        {
            Performance = domain.Performance,
        };
}