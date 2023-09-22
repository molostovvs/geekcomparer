namespace GeekComparer.Infrastructure.Mappers;

public class ScreenMapper : IMapper<ScreenDto, Screen>
{
    public static Screen ToDomain(ScreenDto dto)
        => new()
        {
            AspectRatio = dto.AspectRatio,
            HasDcDimming = dto.HasDcDimming,
            HdrBrightness = dto.HdrBrightness,
            HdrFormat = HdrFormat.FromName(dto.HdrFormat).GetValueOrThrow(),
            HdrSupport = dto.HdrSupport,
            HeightInPixels = dto.HeightInPixels,
            MatriceTechnology = ScreenMatriceTechnology.FromName(dto.MatriceTechnology)
               .GetValueOrThrow(),
            MaxBrightness = dto.MaxBrightness,
            MaxRefreshRatio = dto.MaxRefreshRatio,
            MinRefreshRatio = dto.MinRefreshRatio,
            Size = dto.Size,
            WidthInPixels = dto.WidthInPixels,
        };

    public static ScreenDto ToDto(Screen domain)
        => new()
        {
            AspectRatio = domain.AspectRatio,
            HasDcDimming = domain.HasDcDimming,
            HdrBrightness = domain.HdrBrightness,
            HdrFormat = domain.HdrFormat.Name,
            HdrSupport = domain.HdrSupport,
            HeightInPixels = domain.HeightInPixels,
            MatriceTechnology = domain.MatriceTechnology.Name,
            MaxBrightness = domain.MaxBrightness,
            MaxRefreshRatio = domain.MaxRefreshRatio,
            MinRefreshRatio = domain.MinRefreshRatio,
            Size = domain.Size,
            WidthInPixels = domain.WidthInPixels,
        };
}