namespace GeekComparer.Domain;

public class Sound : ValueObject
{
    public SpeakerType SpeakerType { get; set; }
    public bool HasHeadphoneJack { get; set; }
    public bool HasFmRadio { get; set; }
    public IReadOnlyList<Codec> Codecs { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SpeakerType;
        yield return HasHeadphoneJack;
        yield return HasFmRadio;
        foreach (var codec in Codecs)
            yield return codec;
    }
}

public class SpeakerType : EnumValueObject<SpeakerType, int>
{
    public static readonly SpeakerType Mono = new(1, nameof(Mono));
    public static readonly SpeakerType Stereo = new(2, nameof(Stereo));

    private SpeakerType(int id, string name) : base(id, name) {}
}

public class Codec : EnumValueObject<Codec, int>
{
    public static readonly Codec SBC = new(1, nameof(SBC));
    public static readonly Codec aptX = new(2, nameof(aptX));
    public static readonly Codec aptX_HD = new(3, nameof(aptX_HD));
    public static readonly Codec LDAC = new(4, nameof(LDAC));
    public static readonly Codec LHDC = new(5, nameof(LHDC));
    public static readonly Codec LLAC = new(6, nameof(LLAC));

    private Codec(int id, string name) : base(id, name) {}
}