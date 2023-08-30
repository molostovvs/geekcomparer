namespace GeekComparer.Domain;

public class SoC : ValueObject
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public DateOnly LaunchDate { get; set; }
    public int Litography { get; set; }
    public CPU CPU { get; set; }
    public GPU GPU { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Manufacturer;
        yield return Model;
        yield return LaunchDate;
        yield return Litography;
        yield return CPU;
        yield return GPU;
    }
}

public class GPU : ValueObject
{
    public string Model { get; set; }
    public int MaxClock { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Model;
        yield return MaxClock;
    }
}

public class CPU : ValueObject
{
    public int CoresCount { get; set; }
    public IReadOnlyList<Core> Cores { get; set; }
    public int MaxClock { get; set; }
    public int TDP { get; set; }
    public int L3Cache { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return CoresCount;
        foreach (var core in Cores)
            yield return core;
        yield return MaxClock;
        yield return TDP;
        yield return L3Cache;
    }
}

public class Core : ValueObject
{
    public DateOnly LaunchDate { get; set; }
    public string Architecture { get; set; } //TODO: implement as EnumVO

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return LaunchDate;
        yield return Architecture;
    }
}