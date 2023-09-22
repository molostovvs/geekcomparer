namespace GeekComparer.Infrastructure.Mappers;

public class ChargingMapper : IMapper<ChargingDto, Charging>
{
    public static Charging ToDomain(ChargingDto dto)
        => new()
        {
            WiredChargePower = dto.WiredChargePower,
            WirelessChargingSupported = dto.WirelessChargingSupported,
            WirelessChargePower = dto.WirelessChargePower,
            ReverseChargingSupported = dto.ReverseChargingSupported,
            ReverseChargePower = dto.ReverseChargePower,
            FullChargingTime = dto.FullChargingTime,
            HalfChargingTime = dto.HalfChargingTime,
        };

    public static ChargingDto ToDto(Charging domain)
        => new()
        {
            WiredChargePower = domain.WiredChargePower,
            WirelessChargingSupported = domain.WirelessChargingSupported,
            WirelessChargePower = domain.WirelessChargePower,
            ReverseChargingSupported = domain.ReverseChargingSupported,
            ReverseChargePower = domain.ReverseChargePower,
            FullChargingTime = domain.FullChargingTime,
            HalfChargingTime = domain.HalfChargingTime,
        };
}