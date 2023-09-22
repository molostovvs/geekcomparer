namespace GeekComparer.Infrastructure.Mappers;

public class DxOMarkBenchmarkMapper : IMapper<DxOMarkBenchmarkDto, DxOMarkBenchmark>
{
    public static DxOMarkBenchmark ToDomain(DxOMarkBenchmarkDto dto)
        => new()
        {
            Photo = dto.Photo,
            Video = dto.Video,
            Zoom = dto.Zoom,
            Bokeh = dto.Bokeh,
            Preview = dto.Preview,
        };

    public static DxOMarkBenchmarkDto ToDto(DxOMarkBenchmark domain)
        => new()
        {
            Photo = domain.Photo,
            Video = domain.Video,
            Zoom = domain.Zoom,
            Bokeh = domain.Bokeh,
            Preview = domain.Preview,
        };
}