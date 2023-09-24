namespace GeekComparer.Domain.Enums;

public class BatteryType : EnumValueObject<BatteryType, int>
{
    public static readonly BatteryType LiPo = new(1, nameof(LiPo));
    public static readonly BatteryType LiIon = new(2, nameof(LiIon));
    public static readonly BatteryType NiCd = new(3, nameof(NiCd));
    public static readonly BatteryType NiMH = new(4, nameof(NiMH));

    private BatteryType(int id, string name) : base(id, name) {}
}