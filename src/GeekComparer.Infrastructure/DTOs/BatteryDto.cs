namespace GeekComparer.Infrastructure.DTOs;

public class BatteryDto
{
    public int Capacity { get; set; }
    public string Type { get; set; }
    public bool Replaceable { get; set; }
    public BatteryLifeDto Life { get; set; }
}