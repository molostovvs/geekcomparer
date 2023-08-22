namespace GeekComparer.Domain;

public class Memory : ValueObject
{
    public RAM RAM { get; set; }
    public Storage Storage { get; set; }
    public bool MemoryCardSupported { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return RAM;
        yield return Storage;
        yield return MemoryCardSupported;
    }
}

public class RAM : ValueObject
{
    public int Size { get; set; }
    public RamType Type { get; set; }
    public int Clock { get; set; }
    public int Channels { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Size;
        yield return Type;
        yield return Clock;
        yield return Channels;
    }
}

public class RamType : EnumValueObject<RamType, int>
{
    public static readonly RamType LPDDR1 = new(1, nameof(LPDDR1));
    public static readonly RamType LPDDR2 = new(2, nameof(LPDDR2));
    public static readonly RamType LPDDR3 = new(3, nameof(LPDDR3));
    public static readonly RamType LPDDR3E = new(4, nameof(LPDDR3E));
    public static readonly RamType LPDDR4 = new(5, nameof(LPDDR4));
    public static readonly RamType LPDDR4X = new(6, nameof(LPDDR4X));
    public static readonly RamType LPDDR5 = new(7, nameof(LPDDR5));
    public static readonly RamType LPDDR5X = new(8, nameof(LPDDR5X));
    public static readonly RamType LPDDR5T = new(9, nameof(LPDDR5T));

    private RamType(int id, string name) : base(id, name) {}
}

public class Storage : ValueObject
{
    public int Size { get; set; }
    public Maybe<int> StorageVersion { get; set; }
    public StorageType Type { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Size;
        yield return Type;
        yield return StorageVersion.HasValue ? StorageVersion.Value : int.MinValue;
    }
}

public class StorageType : EnumValueObject<StorageType, int>
{
    public static readonly StorageType UFS = new(1, nameof(UFS));
    public static readonly StorageType eMMC = new(1, nameof(eMMC));
    public static readonly StorageType Unspecified = new(1, nameof(Unspecified));

    private StorageType(int id, string name) : base(id, name) {}
}