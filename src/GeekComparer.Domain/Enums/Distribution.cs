namespace GeekComparer.Domain.Enums;

public class Distribution : EnumValueObject<Distribution, int>
{
    public static readonly Distribution MIUI = new(1, nameof(MIUI));
    public static readonly Distribution FunTouch = new(2, nameof(FunTouch));
    public static readonly Distribution EMUI = new(3, nameof(EMUI));
    public static readonly Distribution FireOS = new(4, nameof(FireOS));

    private Distribution(int id, string name) : base(id, name) {}
}