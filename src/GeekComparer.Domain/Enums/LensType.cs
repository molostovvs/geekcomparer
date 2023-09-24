namespace GeekComparer.Domain.Enums;

public class LensType : EnumValueObject<LensType, int>
{
    public static readonly LensType Normal = new(1, nameof(Normal));
    public static readonly LensType Wide = new(2, nameof(Wide));
    public static readonly LensType UltraWide = new(3, nameof(UltraWide));
    public static readonly LensType Telephoto = new(4, nameof(Telephoto));
    public static readonly LensType Depth = new(5, nameof(Depth));

    private LensType(int id, string name) : base(id, name) {}
}