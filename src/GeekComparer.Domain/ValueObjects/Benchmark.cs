namespace GeekComparer.Domain.ValueObjects;

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