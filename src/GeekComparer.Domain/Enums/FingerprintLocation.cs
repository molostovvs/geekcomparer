namespace GeekComparer.Domain.Enums;

public class FingerprintLocation : EnumValueObject<FingerprintLocation, int>
{
    public static readonly FingerprintLocation Screen = new(1, nameof(Screen));
    public static readonly FingerprintLocation Button = new(2, nameof(Button));
    public static readonly FingerprintLocation Side = new(3, nameof(Side));
    public static readonly FingerprintLocation Back = new(4, nameof(Back));

    private FingerprintLocation(int id, string name) : base(id, name) {}
}