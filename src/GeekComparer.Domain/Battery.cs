namespace GeekComparer.Domain;

public class Battery : ValueObject
{
    public int Capacity { get; set; }
    public BatteryType Type { get; set; }
    public int WiredChargePower { get; set; }
    public bool WirelessChargingSupported { get; set; }
    public int WirelessChargePower { get; set; }
    public bool ReverseChargingSupported { get; set; }
    public int ReverseChargePower { get; set; }
    public TimeSpan FullChargingTime { get; set; }
    public bool Replaceable { get; set; }
    public BatteryLife Life { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class BatteryLife
{
    public TimeSpan WebBrowsing { get; set; }
    public TimeSpan Video { get; set; }
    public TimeSpan Gaming { get; set; }
    public TimeSpan Standby { get; set; }
}

public enum BatteryType
{
    LiPo, LiIon,
}