namespace GeekComparer.Domain;

public class OperatingSystem : EnumValueObject<OperatingSystem, int>
{
    public static readonly OperatingSystem Android = new(1, nameof(Android));
    public static readonly OperatingSystem iOS = new(2, nameof(iOS));
    public static readonly OperatingSystem Linux = new(3, nameof(Linux));
    public static readonly OperatingSystem WindowsPhone = new(4, nameof(WindowsPhone));
    public static readonly OperatingSystem HarmonyOS = new(5, nameof(HarmonyOS));
    public static readonly OperatingSystem Symbian = new(6, nameof(Symbian));

    private OperatingSystem(int id, string name) : base(id, name) {}
}