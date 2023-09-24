namespace GeekComparer.Domain.Enums;

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