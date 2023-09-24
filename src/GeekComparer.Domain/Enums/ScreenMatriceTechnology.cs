namespace GeekComparer.Domain.Enums;

public class ScreenMatriceTechnology : EnumValueObject<ScreenMatriceTechnology, int>
{
    public static readonly ScreenMatriceTechnology IPS = new(1, nameof(IPS));
    public static readonly ScreenMatriceTechnology OLED = new(2, nameof(OLED));
    public static readonly ScreenMatriceTechnology EInk = new(3, nameof(EInk));

    private ScreenMatriceTechnology(int id, string name) : base(id, name) {}
}