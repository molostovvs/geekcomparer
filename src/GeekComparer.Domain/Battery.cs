namespace GeekComparer.Domain;

public class Battery : ValueObject
{
    public int Capacity { get; set; }
    public BatteryType Type { get; set; }
    public bool Replaceable { get; set; }
    public BatteryLife Life { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Capacity;
        yield return Type;
        yield return Replaceable;
        yield return Life;
    }
}

public class BatteryLife : ValueObject
{
    public Maybe<TimeSpan> WebBrowsing { get; set; }
    public Maybe<TimeSpan> Video { get; set; }
    public Maybe<TimeSpan> Gaming { get; set; }
    public Maybe<TimeSpan> Standby { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return WebBrowsing.HasValue ? WebBrowsing.Value : TimeSpan.MinValue;
        yield return Video.HasValue ? Video.Value : TimeSpan.MinValue;
        yield return Gaming.HasValue ? Gaming.Value : TimeSpan.MinValue;
        yield return Standby.HasValue ? Standby.Value : TimeSpan.MinValue;
    }
}

public class BatteryType : EnumValueObject<BatteryType, int>
{
    public static readonly BatteryType LiPo = new(1, nameof(LiPo));
    public static readonly BatteryType LiIon = new(2, nameof(LiIon));
    public static readonly BatteryType NiCd = new(3, nameof(NiCd));
    public static readonly BatteryType NiMH = new(4, nameof(NiMH));

    private BatteryType(int id, string name) : base(id, name) {}
}