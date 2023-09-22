namespace GeekComparer.Infrastructure.DTOs;

public class SoundDto
{
    public string SpeakerType { get; set; }
    public bool HasHeadphoneJack { get; set; }
    public bool HasFmRadio { get; set; }
    public List<string> Codecs { get; set; }
}