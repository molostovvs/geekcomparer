namespace GeekComparer.Domain.ValueObjects;

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