namespace GeekComparer.Infrastructure.DTOs;

public class BatteryLifeDto
{
    public TimeSpan WebBrowsing { get; set; }
    public TimeSpan Video { get; set; }
    public TimeSpan Gaming { get; set; }
    public TimeSpan Standby { get; set; }
}