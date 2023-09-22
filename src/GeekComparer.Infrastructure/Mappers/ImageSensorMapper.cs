namespace GeekComparer.Infrastructure.Mappers;

public class ImageSensorMapper : IMapper<ImageSensorDto, ImageSensor>
{
    public static ImageSensor ToDomain(ImageSensorDto dto)
        => new()
        {
            Format = new string(dto.Format),
            Manufacturer = new string(dto.Manufacturer),
            Model = new string(dto.Model),
        };

    public static ImageSensorDto ToDto(ImageSensor domain)
        => new()
        {
            Format = new string(domain.Format),
            Manufacturer = new string(domain.Manufacturer),
            Model = new string(domain.Model),
        };
}