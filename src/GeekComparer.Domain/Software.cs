namespace GeekComparer.Domain;

public class Software : ValueObject
{
    public Distribution Distribution { get; set; }
    public OperatingSystem OperatingSystem { get; set; }
    public int DistributionVersion { get; set; }
    public int OperatingSystemVersion { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Distribution;
        yield return OperatingSystem;
        yield return DistributionVersion;
        yield return OperatingSystemVersion;
    }
}

public class Distribution : EnumValueObject<Distribution, int>
{
    public static readonly Distribution MIUI = new(1, nameof(MIUI));
    public static readonly Distribution FunTouch = new(2, nameof(FunTouch));
    public static readonly Distribution EMUI = new(3, nameof(EMUI));
    public static readonly Distribution FireOS = new(4, nameof(FireOS));

    private Distribution(int id, string name) : base(id, name) {}
}

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