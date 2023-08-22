namespace GeekComparer.Domain;

public class Connectivity : ValueObject
{
    public Cellular Cellular { get; set; }
    public WiFi WiFi { get; set; }
    public Bluetooth Bluetooth { get; set; }
    public IReadOnlyList<NavigationSystem> NavigationSystems { get; set; }
    public USB USB { get; set; }
    public bool HasNFC { get; set; }
    public bool HasIR { get; set; }
    public bool HasUWB { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Cellular;
        yield return WiFi;
        yield return Bluetooth;

        foreach (var ns in NavigationSystems)
            yield return ns;

        yield return USB;
    }
}

public class Cellular : ValueObject
{
    public int SimCount { get; set; }
    public IReadOnlyList<SimType> SimType { get; set; }
    public MultiSimMode MultiSimMode { get; set; }
    public string[] Bands2G { get; set; }
    public string[] Bands3G { get; set; }
    public string[] Bands4G { get; set; }
    public string[] Bands5G { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SimCount;
        foreach (var simType in SimType)
            yield return simType;
        yield return MultiSimMode;

        foreach (var s in Bands2G)
            yield return s;

        foreach (var s in Bands3G)
            yield return s;

        foreach (var s in Bands4G)
            yield return s;

        foreach (var s in Bands5G)
            yield return s;
    }
}

public class MultiSimMode : EnumValueObject<MultiSimMode, int>
{
    public static readonly MultiSimMode Standby = new(1, nameof(Standby));
    public static readonly MultiSimMode Active = new(2, nameof(Active));

    private MultiSimMode(int id, string name) : base(id, name) {}
}

public class SimType : EnumValueObject<SimType, int>
{
    public static readonly SimType Standard = new(1, nameof(Standard));
    public static readonly SimType Mini = new(2, nameof(Mini));
    public static readonly SimType Micro = new(3, nameof(Micro));
    public static readonly SimType Nano = new(4, nameof(Nano));
    public static readonly SimType Embedded = new(5, nameof(Embedded));
    public static readonly SimType Integrated = new(6, nameof(Integrated));

    private SimType(int id, string name) : base(id, name) {}
}

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

public class USB : ValueObject
{
    public string Version { get; set; }
    public USBConnector Connector { get; set; }
    public IReadOnlyList<USBFeatures> Features { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Version;
        yield return Connector;

        foreach (var feature in Features)
            yield return feature;
    }
}

public class USBFeatures : EnumValueObject<USBFeatures, int>
{
    public static readonly USBFeatures Charging = new(1, nameof(Charging));
    public static readonly USBFeatures OTG = new(2, nameof(OTG));
    public static readonly USBFeatures StorageMode = new(3, nameof(StorageMode));

    private USBFeatures(int id, string name) : base(id, name) {}
}

public class USBConnector : EnumValueObject<USBConnector, int>
{
    public static readonly USBConnector C = new(1, nameof(C));
    public static readonly USBConnector Micro = new(2, nameof(Micro));
    public static readonly USBConnector Lightning = new(3, nameof(Lightning));

    private USBConnector(int id, string name) : base(id, name) {}
}

public class Bluetooth : ValueObject
{
    public string Version { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Version;
    }
}

public class WiFi : ValueObject
{
    public IReadOnlyList<WiFiStandard> Standards { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => Standards;
}

public class WiFiStandard : EnumValueObject<WiFiStandard, int>
{
    public static readonly WiFiStandard b = new(1, nameof(b));
    public static readonly WiFiStandard a = new(2, nameof(a));
    public static readonly WiFiStandard g = new(3, nameof(g));
    public static readonly WiFiStandard n = new(4, nameof(n));
    public static readonly WiFiStandard ac = new(5, nameof(ac));
    public static readonly WiFiStandard ax = new(6, nameof(ax));
    public static readonly WiFiStandard be = new(7, nameof(be));

    private WiFiStandard(int id, string name) : base(id, name) {}
}