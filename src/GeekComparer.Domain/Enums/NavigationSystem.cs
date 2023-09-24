namespace GeekComparer.Domain.Enums;

public class NavigationSystem : EnumValueObject<NavigationSystem, int>
{
    public static readonly NavigationSystem GPS = new(1, nameof(GPS));
    public static readonly NavigationSystem GLONASS = new(2, nameof(GLONASS));
    public static readonly NavigationSystem Beidou = new(3, nameof(Beidou));
    public static readonly NavigationSystem Galileo = new(4, nameof(Galileo));
    public static readonly NavigationSystem QZSS = new(5, nameof(QZSS));
    public static readonly NavigationSystem NAVIC = new(6, nameof(NAVIC));

    private NavigationSystem(int id, string name) : base(id, name) {}
}