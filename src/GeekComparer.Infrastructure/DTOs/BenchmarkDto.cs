namespace GeekComparer.Infrastructure.DTOs;

public class BenchmarkDto
{
    public GeekbenchBenchmarkDto Geekbench5 { get; set; }
    public AntutuBenchmarkDto Antutu { get; set; }
    public ThreeDMarkBenchmarkDto ThreeDMark { get; set; }
    public DxOMarkBenchmarkDto DxOMark { get; set; }
}