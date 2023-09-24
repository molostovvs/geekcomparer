namespace GeekComparer.Domain.ValueObjects;

public class Sound : ValueObject
{
    public SpeakerType SpeakerType { get; set; }
    public bool HasHeadphoneJack { get; set; }
    public bool HasFmRadio { get; set; }
    public IReadOnlyList<AudioCodec> Codecs { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SpeakerType;
        yield return HasHeadphoneJack;
        yield return HasFmRadio;
        foreach (var codec in Codecs)
            yield return codec;
    }
}