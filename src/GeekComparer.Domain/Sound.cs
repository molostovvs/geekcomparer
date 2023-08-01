namespace GeekComparer.Domain;

public class Sound : ValueObject
{
    public SpeakersType SpeakersType { get; set; }
    public bool HeadphoneJack { get; set; }
    public bool FMRadio { get; set; }
    public bool DolbyAtmos { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public enum SpeakersType
{
    Stereo, Mono,
}