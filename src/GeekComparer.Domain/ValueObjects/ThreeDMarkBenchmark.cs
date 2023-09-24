namespace GeekComparer.Domain.ValueObjects;

public class ThreeDMarkBenchmark : ValueObject
{
    public int Performance { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Performance;
    }
}