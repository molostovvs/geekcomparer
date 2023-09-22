namespace GeekComparer.Infrastructure.DTOs;

public class GeekbenchBenchmarkDto
{
    public int SingleCore { get; set; }
    public int MultiCore { get; set; }
    public int OpenCL { get; set; }
    public int Vulkan { get; set; }
    public int Metal { get; set; }
}