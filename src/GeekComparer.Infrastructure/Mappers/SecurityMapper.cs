namespace GeekComparer.Infrastructure.Mappers;

public class SecurityMapper : IMapper<SecurityDto, Security>
{
    public static Security ToDomain(SecurityDto dto)
        => new()
        {
            HasCoprocessor = dto.HasCoprocessor,
            HasFaceUnlock = dto.HasFaceUnlock,
            HasFingerprintUnlock = dto.HasFingerprintUnlock,
            HasIrisUnlock = dto.HasIrisUnlock,
        };

    public static SecurityDto ToDto(Security domain)
        => new()
        {
            HasCoprocessor = domain.HasCoprocessor,
            HasFaceUnlock = domain.HasFaceUnlock,
            HasFingerprintUnlock = domain.HasFingerprintUnlock,
            HasIrisUnlock = domain.HasIrisUnlock,
        };
}