namespace GeekComparer.Domain.ValueObjects;

public class Charging : ValueObject
{
    public int WiredChargePower { get; set; }
    public bool WirelessChargingSupported { get; set; }
    public int WirelessChargePower { get; set; }
    public bool ReverseChargingSupported { get; set; }
    public int ReverseChargePower { get; set; }
    public TimeSpan FullChargingTime { get; set; }
    public TimeSpan HalfChargingTime { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return WiredChargePower;
        yield return WirelessChargingSupported;
        yield return WirelessChargePower;
        yield return ReverseChargingSupported;
        yield return ReverseChargePower;
        yield return FullChargingTime;
        yield return HalfChargingTime;
    }
}