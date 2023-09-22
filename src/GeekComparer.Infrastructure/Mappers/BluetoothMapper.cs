namespace GeekComparer.Infrastructure.Mappers;

public class BluetoothMapper : IMapper<BluetoothDto, Bluetooth>
{
    public static Bluetooth ToDomain(BluetoothDto dto)
        => new()
        {
            Version = new string(dto.Version),
        };

    public static BluetoothDto ToDto(Bluetooth domain)
        => new()
        {
            Version = new string(domain.Version),
        };
}