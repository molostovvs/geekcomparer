namespace GeekComparer.Domain.ValueObjects;

public class Cpu : ValueObject
{
    public IReadOnlyList<Core> Cores { get; set; }
    public int Tdp { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        foreach (var core in Cores)
            yield return core;
        yield return Tdp;
    }
}