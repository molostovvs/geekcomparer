namespace GeekComparer.Infrastructure.Mappers;

public class SoftwareMapper : IMapper<SoftwareDto, Software>
{
    public static Software ToDomain(SoftwareDto dto)
        => new()
        {
            Distribution = Distribution.FromName(dto.Distribution).GetValueOrThrow(),
            DistributionVersion = dto.DistributionVersion,
            OperatingSystem =
                Domain.OperatingSystem.FromName(dto.OperatingSystem).GetValueOrThrow(),
            OperatingSystemVersion = dto.OperatingSystemVersion,
        };

    public static SoftwareDto ToDto(Software domain)
        => new()
        {
            Distribution = new string(domain.Distribution.Name),
            DistributionVersion = domain.DistributionVersion,
            OperatingSystem = new string(domain.OperatingSystem.Name),
            OperatingSystemVersion = domain.OperatingSystemVersion,
        };
}