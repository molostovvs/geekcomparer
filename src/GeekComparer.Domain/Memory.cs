namespace GeekComparer.Domain;

public class Memory : ValueObject
{
    public RAM Ram { get; set; }
    public ROM Rom { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class RAM
{
    public int Size { get; set; }
    public RamType Type { get; set; }
    public int Clock { get; set; }
    public int Channels { get; set; }
}

public enum RamType
{
    LPDDR4, LPDDR4X, LPDDR5X,
}

public class ROM
{
    public int Size { get; set; }
    public RomType Type { get; set; }
    public bool MemoryCardSupported { get; set; }
}

public enum RomType
{
    UFS40,
    UFS31,
}