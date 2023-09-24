namespace GeekComparer.Domain.Enums;

public class TwoGBand : EnumValueObject<TwoGBand, int>
{
    public static readonly TwoGBand TGSM380 = new(1, nameof(TGSM380));
    public static readonly TwoGBand TGSM410 = new(2, nameof(TGSM410));
    public static readonly TwoGBand GSM450 = new(3, nameof(GSM450));
    public static readonly TwoGBand GSM480 = new(4, nameof(GSM480));
    public static readonly TwoGBand GSM710 = new(5, nameof(GSM710));
    public static readonly TwoGBand GSM750 = new(6, nameof(GSM750));
    public static readonly TwoGBand TGSM810 = new(7, nameof(TGSM810));
    public static readonly TwoGBand GSM850 = new(8, nameof(GSM850));
    public static readonly TwoGBand EGSM900 = new(9, nameof(EGSM900));
    public static readonly TwoGBand RGSM900 = new(10, nameof(RGSM900));
    public static readonly TwoGBand TGSM900 = new(11, nameof(TGSM900));
    public static readonly TwoGBand DCS1800 = new(12, nameof(DCS1800));
    public static readonly TwoGBand PCS1900 = new(13, nameof(PCS1900));

    private TwoGBand(int id, string name) : base(id, name) {}
}