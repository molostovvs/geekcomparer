namespace GeekComparer.Infrastructure.Mappers;

public class VideoModeMapper : IMapper<VideoModeDto, VideoMode>
{
    public static VideoMode ToDomain(VideoModeDto dto)
        => new()
        {
            FrameRate = dto.FrameRate,
            Resolution = new string(dto.Resolution),
        };

    public static VideoModeDto ToDto(VideoMode domain)
        => new()
        {
            FrameRate = domain.FrameRate,
            Resolution = new string(domain.Resolution),
        };
}