namespace GeekComparer.Infrastructure.Mappers;

public class PhotoCapabilitiesMapper : IMapper<PhotoCapabilitiesDto, PhotoCapabilities>
{
    public static PhotoCapabilities ToDomain(PhotoCapabilitiesDto dto)
        => new()
        {
            MaxWidth = dto.MaxWidth,
            MaxHeight = dto.MaxHeight,
        };

    public static PhotoCapabilitiesDto ToDto(PhotoCapabilities domain)
        => new()
        {
            MaxHeight = domain.MaxHeight,
            MaxWidth = domain.MaxWidth,
            MaxResolution = new string(domain.MaxResolution),
        };
}