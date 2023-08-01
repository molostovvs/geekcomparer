namespace GeekComparer.Domain;

public class SoC : ValueObject
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public CPU CPU { get; set; }
    public GPU GPU { get; set; }
    public int Litography { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class GPU
{
    public string Name { get; set; }
    public int Clock { get; set; }
}

public class CPU
{
    public int CoresCount { get; set; }
    public Core[] Cores { get; set; }
    public int L3Cache { get; set; }
    public int MaxClock { get; set; }
}

public class Core
{
    public double Clock { get; set; }
    public double Architecture { get; set; }
}