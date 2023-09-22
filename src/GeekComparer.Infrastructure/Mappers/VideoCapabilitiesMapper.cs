namespace GeekComparer.Infrastructure.Mappers;

public class VideoCapabilitiesMapper : IMapper<VideoCapabilitiesDto, VideoCapabilities>
{
    public static VideoCapabilities ToDomain(VideoCapabilitiesDto dto)
        => new()
        {
            Modes = dto.Modes.Select(VideoModeMapper.ToDomain).ToList(),
        };

    public static VideoCapabilitiesDto ToDto(VideoCapabilities domain)
        => new()
        {
            Modes = domain.Modes.Select(VideoModeMapper.ToDto).ToList(),
        };
}