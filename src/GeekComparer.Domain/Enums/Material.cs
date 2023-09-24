namespace GeekComparer.Domain.Enums;

public class Material : EnumValueObject<Material, int>
{
    public static readonly Material Metal = new(1, nameof(Metal));
    public static readonly Material Glass = new(2, nameof(Glass));
    public static readonly Material Plastic = new(3, nameof(Plastic));
    public static readonly Material Carbon = new(4, nameof(Carbon));
    public static readonly Material Ceramic = new(5, nameof(Ceramic));

    private Material(int id, string name) : base(id, name) {}
}