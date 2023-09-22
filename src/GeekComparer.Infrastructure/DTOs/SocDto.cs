namespace GeekComparer.Infrastructure.DTOs;

public class SocDto
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public DateOnly LaunchDate { get; set; }
    public int Litography { get; set; }
    public CpuDto Cpu { get; set; }
    public GpuDto Gpu { get; set; }
}