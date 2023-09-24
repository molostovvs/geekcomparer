namespace GeekComparer.Domain.Enums;

public class SimFormat : EnumValueObject<SimFormat, int>
{
    public static readonly SimFormat Standard = new(1, nameof(Standard));
    public static readonly SimFormat Mini = new(2, nameof(Mini));
    public static readonly SimFormat Micro = new(3, nameof(Micro));
    public static readonly SimFormat Nano = new(4, nameof(Nano));
    public static readonly SimFormat Embedded = new(5, nameof(Embedded));
    public static readonly SimFormat Integrated = new(6, nameof(Integrated));

    private SimFormat(int id, string name) : base(id, name) {}
}