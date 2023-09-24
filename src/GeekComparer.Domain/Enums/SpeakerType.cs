namespace GeekComparer.Domain.Enums;

public class SpeakerType : EnumValueObject<SpeakerType, int>
{
    public static readonly SpeakerType Mono = new(1, nameof(Mono));
    public static readonly SpeakerType Stereo = new(2, nameof(Stereo));

    private SpeakerType(int id, string name) : base(id, name) {}
}