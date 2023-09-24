namespace GeekComparer.Domain.Enums;

public class AudioCodec : EnumValueObject<AudioCodec, int>
{
    public static readonly AudioCodec SBC = new(1, nameof(SBC));
    public static readonly AudioCodec aptX = new(2, nameof(aptX));
    public static readonly AudioCodec aptX_HD = new(3, nameof(aptX_HD));
    public static readonly AudioCodec LDAC = new(4, nameof(LDAC));
    public static readonly AudioCodec LHDC = new(5, nameof(LHDC));
    public static readonly AudioCodec LLAC = new(6, nameof(LLAC));

    private AudioCodec(int id, string name) : base(id, name) {}
}