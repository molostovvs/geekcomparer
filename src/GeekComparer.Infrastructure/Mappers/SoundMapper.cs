namespace GeekComparer.Infrastructure.Mappers;

public class SoundMapper : IMapper<SoundDto, Sound>
{
    public static Sound ToDomain(SoundDto dto)
        => new()
        {
            SpeakerType = SpeakerType.FromName(dto.SpeakerType).GetValueOrThrow(),
            HasHeadphoneJack = dto.HasHeadphoneJack,
            HasFmRadio = dto.HasFmRadio,
            Codecs = dto.Codecs.Select(c => AudioCodec.FromName(c).GetValueOrThrow()).ToList(),
        };

    public static SoundDto ToDto(Sound domain)
        => new()
        {
            SpeakerType = domain.SpeakerType.Name,
            Codecs = domain.Codecs.Select(c => c.Name).ToList(),
            HasHeadphoneJack = domain.HasHeadphoneJack,
            HasFmRadio = domain.HasFmRadio,
        };
}