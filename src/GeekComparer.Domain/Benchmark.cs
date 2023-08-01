namespace GeekComparer.Domain;

public class Benchmark
{
    public GeekbenchBenchmark Geekbench5 { get; set; }
    public AntutuBenchmark Antutu { get; set; }
    public ThreeDMarkBenchmark ThreeDMark { get; set; }
    public DxOMarkBenchmark DxOMark { get; set; }
}

public class DxOMarkBenchmark {}

public class ThreeDMarkBenchmark {}

public class AntutuBenchmark {}

public class GeekbenchBenchmark {}