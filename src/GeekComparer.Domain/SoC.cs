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
    public IReadOnlyList<Core> Cores { get; set; }
    public int TDP { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        foreach (var core in Cores)
            yield return core;
        yield return TDP;
    }
}

public class Core : ValueObject
{
    public int Clock { get; set; }
    public string InstructionSet { get; set; }    //TODO: implement as EnumVO?
    public string Microarchitecture { get; set; } //TODO: implement as EnumVO?
    public DateOnly LaunchDate { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Clock;
        yield return InstructionSet;
        yield return Microarchitecture;
        yield return LaunchDate;
    }
}