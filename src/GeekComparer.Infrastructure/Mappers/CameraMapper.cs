namespace GeekComparer.Infrastructure.Mappers;

public class CameraMapper : IMapper<CameraDto, Camera>
{
    public static Camera ToDomain(CameraDto dto)
        => new()
        {
            PhotoCapabilities = PhotoCapabilitiesMapper.ToDomain(dto.PhotoCapabilities),
            VideoCapabilities = VideoCapabilitiesMapper.ToDomain(dto.VideoCapabilities),
            Aperture = dto.Aperture,
            Autofocus = Autofocus.FromName(dto.Autofocus).GetValueOrThrow(),
            DigitalZoomValue = dto.DigitalZoomValue,
            FocalLength = dto.FocalLength,
            HasOpticalZoom = dto.HasOpticalZoom,
            LensType = LensType.FromName(dto.LensType).GetValueOrThrow(),
            Matrix = dto.Matrix,
            OpticalZoomValue = dto.OpticalZoomValue,
            PixelSize = dto.PixelSize,
            Sensor = ImageSensorMapper.ToDomain(dto.Sensor),
            Stabilization = ImageStabilization.FromName(dto.Stabilization).GetValueOrThrow(),
        };

    public static CameraDto ToDto(Camera domain)
        => new()
        {
            PhotoCapabilities = PhotoCapabilitiesMapper.ToDto(domain.PhotoCapabilities),
            VideoCapabilities = VideoCapabilitiesMapper.ToDto(domain.VideoCapabilities),
            Aperture = domain.Aperture,
            Autofocus = domain.Autofocus.Name,
            DigitalZoomValue = domain.DigitalZoomValue,
            FocalLength = domain.FocalLength,
            HasOpticalZoom = domain.HasOpticalZoom,
            LensType = domain.LensType.Name,
            Matrix = domain.Matrix,
            OpticalZoomValue = domain.OpticalZoomValue,
            PixelSize = domain.PixelSize,
            Sensor = ImageSensorMapper.ToDto(domain.Sensor),
            Stabilization = domain.Stabilization.Name,
        };
}