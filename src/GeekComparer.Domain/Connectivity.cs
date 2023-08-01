// ReSharper disable InconsistentNaming

namespace GeekComparer.Domain;

public class Connectivity : ValueObject
{
    public WiFi WiFi { get; set; }
    public Bluetooth Bluetooth { get; set; }
    public USB Usb { get; set; }
    public NavigationSystem[] NavigationSystem { get; set; }

    public bool NFC { get; set; }
    public bool IR { get; set; }
    public MobileNetwork MobileNetwork { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class MobileNetwork
{
    public int SimNumber { get; set; }
    public SimType SimType { get; set; }
    public MultiSimMode MultiSimMode { get; set; }
    public bool eSim { get; set; }
    public bool HybridSlot { get; set; }
    public string[] SecondGBands { get; set; }
    public string[] ThirdGBands { get; set; }
    public string[] FourthGBands { get; set; }
    public string[] FifthGBands { get; set; }
}

public enum MultiSimMode
{
    Standby,
}

public enum SimType
{
    nano,
}

public enum NavigationSystem
{
    GPS,
    GLONASS,
    Beidou,
    Galileo,
    QZSS,
    NAVIC }

public class USB
{
    public string Version { get; set; }
    public USBType Type { get; set; }
    public USBFeatures[] Features { get; set; }
}

public enum USBFeatures
{
    Charging, StorageMode, OTG,
}

public enum USBType
{
    C, Micro, Lightning,
}

public class Bluetooth
{
    public string Version { get; set; }
    public bool LowEnergy { get; set; }
}

public class WiFi
{
    public string[] Standards { get; set; }
    public WiFiFeatures[] Features { get; set; }
}

public enum WiFiFeatures
{
    DualBand, MIMO, Direct, Hotspot, Display,
}