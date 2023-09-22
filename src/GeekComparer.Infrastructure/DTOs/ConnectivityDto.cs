namespace GeekComparer.Infrastructure.DTOs;

public class ConnectivityDto
{
    public CellularDto Cellular { get; set; }
    public WiFiDto WiFi { get; set; }
    public BluetoothDto Bluetooth { get; set; }
    public List<string> NavigationSystems { get; set; }
    public UsbDto Usb { get; set; }
    public bool HasNFC { get; set; }
    public bool HasIR { get; set; }
    public bool HasUWB { get; set; }
}