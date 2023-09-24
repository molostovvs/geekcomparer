namespace GeekComparer.Domain.Enums;

public class StorageType : EnumValueObject<StorageType, int>
{
    public static readonly StorageType UFS = new(1, nameof(UFS));
    public static readonly StorageType eMMC = new(2, nameof(eMMC));
    public static readonly StorageType Unspecified = new(3, nameof(Unspecified));

    private StorageType(int id, string name) : base(id, name) {}
}