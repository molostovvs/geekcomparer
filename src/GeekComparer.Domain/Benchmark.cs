namespace GeekComparer.Domain;

public class Benchmark : ValueObject
{
    public GeekbenchBenchmark Geekbench5 { get; set; }
    public AntutuBenchmark Antutu { get; set; }
    public ThreeDMarkBenchmark ThreeDMark { get; set; }
    public DxOMarkBenchmark DxOMark { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Geekbench5;
        yield return Antutu;
        yield return ThreeDMark;
        yield return DxOMark;
    }
}

public class DxOMarkBenchmark : ValueObject
{
    public int Photo { get; set; }
    public int Video { get; set; }
    public int Zoom { get; set; }
    public int Bokeh { get; set; }
    public int Preview { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Photo;
        yield return Video;
        yield return Zoom;
        yield return Bokeh;
        yield return Preview;
    }
}

public class ThreeDMarkBenchmark : ValueObject
{
    public int Performance { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Performance;
    }
}

public class AntutuBenchmark : ValueObject
{
    public int CPU { get; set; }
    public int GPU { get; set; }
    public int MEM { get; set; }
    public int UX { get; set; }
    public int Total { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return CPU;
        yield return GPU;
        yield return MEM;
        yield return UX;
        yield return Total;
    }
}

public class GeekbenchBenchmark : ValueObject
{
    public int SingleCore { get; set; }
    public int MultiCore { get; set; }
    public int OpenCL { get; set; }
    public int Vulkan { get; set; }
    public int Metal { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SingleCore;
        yield return MultiCore;
        yield return OpenCL;
        yield return Vulkan;
        yield return Metal;
    }
}