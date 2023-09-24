namespace GeekComparer.Domain.Enums;

public class WiFiStandard : EnumValueObject<WiFiStandard, int>
{
    public static readonly WiFiStandard b = new(1, nameof(b));
    public static readonly WiFiStandard a = new(2, nameof(a));
    public static readonly WiFiStandard g = new(3, nameof(g));
    public static readonly WiFiStandard n = new(4, nameof(n));
    public static readonly WiFiStandard ac = new(5, nameof(ac));
    public static readonly WiFiStandard ax = new(6, nameof(ax));
    public static readonly WiFiStandard be = new(7, nameof(be));

    private WiFiStandard(int id, string name) : base(id, name) {}
}