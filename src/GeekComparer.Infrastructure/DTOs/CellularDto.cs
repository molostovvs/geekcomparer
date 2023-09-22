namespace GeekComparer.Infrastructure.DTOs;

public class CellularDto
{
    public int SimCount { get; set; }
    public List<string> SimFormats { get; set; }
    public string MultiSimMode { get; set; }
    public List<string> Bands2G { get; set; }
    public List<int> Bands3G { get; set; }
    public List<int> Bands4G { get; set; }
    public List<int> Bands5G { get; set; }
}