namespace GeekComparer.Infrastructure.DTOs;

public class ChargingDto
{
    public int WiredChargePower { get; set; }
    public bool WirelessChargingSupported { get; set; }
    public int WirelessChargePower { get; set; }
    public bool ReverseChargingSupported { get; set; }
    public int ReverseChargePower { get; set; }
    public TimeSpan FullChargingTime { get; set; }
    public TimeSpan HalfChargingTime { get; set; }
}