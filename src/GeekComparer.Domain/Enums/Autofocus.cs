namespace GeekComparer.Domain.Enums;

public class Autofocus : EnumValueObject<Autofocus, int>
{
    public static readonly Autofocus Laser = new(1, nameof(Laser));
    public static readonly Autofocus Phase = new(2, nameof(Phase));
    public static readonly Autofocus Contrast = new(3, nameof(Contrast));

    private Autofocus(int id, string name) : base(id, name) {}
}