namespace GeekComparer.Domain.ValueObjects;

public class AntutuBenchmark : ValueObject
{
    public int Cpu { get; set; }
    public int Gpu { get; set; }
    public int Mem { get; set; }
    public int Ux { get; set; }
    public int Total { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Cpu;
        yield return Gpu;
        yield return Mem;
        yield return Ux;
        yield return Total;
    }
}