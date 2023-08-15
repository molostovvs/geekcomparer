namespace GeekComparer.Domain;

public class SoC : Entity
{
    public string Manufacturer { get; set; } //TODO: Implement as EnumVO?
    public string Model { get; set; }
    public DateOnly LaunchDate { get; set; }
    public int Litography { get; set; } //nanometeres
    public CPU CPU { get; set; }
    public GPU GPU { get; set; }
}

public class GPU : ValueObject
{
    public string Model { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Model;
    }
}

public class CPU : ValueObject
{
    public int CoresCount { get; set; }
    public Core[] Cores { get; set; }
    public int L3Cache { get; set; }
    public int TDP { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return CoresCount;
        foreach (var core in Cores)
            yield return core;
        yield return L3Cache;
        yield return TDP;
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