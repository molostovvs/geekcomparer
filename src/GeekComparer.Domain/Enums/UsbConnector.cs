namespace GeekComparer.Domain.Enums;

public class UsbConnector : EnumValueObject<UsbConnector, int>
{
    public static readonly UsbConnector C = new(1, nameof(C));
    public static readonly UsbConnector Micro = new(2, nameof(Micro));
    public static readonly UsbConnector Lightning = new(3, nameof(Lightning));

    private UsbConnector(int id, string name) : base(id, name) {}
}