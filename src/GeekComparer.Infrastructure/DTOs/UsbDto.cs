namespace GeekComparer.Infrastructure.DTOs;

public class UsbDto
{
    public string Version { get; set; }
    public string Connector { get; set; }
    public List<string> Features { get; set; }
}