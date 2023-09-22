namespace GeekComparer.Infrastructure.Mappers;

public class GeekbenchBenchmarkMapper : IMapper<GeekbenchBenchmarkDto, GeekbenchBenchmark>
{
    public static GeekbenchBenchmark ToDomain(GeekbenchBenchmarkDto dto)
        => new()
        {
            SingleCore = dto.SingleCore,
            MultiCore = dto.MultiCore,
            OpenCL = dto.OpenCL,
            Vulkan = dto.Vulkan,
            Metal = dto.Metal,
        };

    public static GeekbenchBenchmarkDto ToDto(GeekbenchBenchmark domain)
        => new()
        {
            SingleCore = domain.SingleCore,
            MultiCore = domain.MultiCore,
            OpenCL = domain.OpenCL,
            Vulkan = domain.Vulkan,
            Metal = domain.Metal,
        };
}