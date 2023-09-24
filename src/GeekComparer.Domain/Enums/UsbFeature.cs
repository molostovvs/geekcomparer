namespace GeekComparer.Domain.Enums;

public class UsbFeature : EnumValueObject<UsbFeature, int>
{
    public static readonly UsbFeature Charging = new(1, nameof(Charging));
    public static readonly UsbFeature OTG = new(2, nameof(OTG));
    public static readonly UsbFeature StorageMode = new(3, nameof(StorageMode));

    private UsbFeature(int id, string name) : base(id, name) {}
}