namespace GeekComparer.Infrastructure.Mappers;

public class BodyMapper : IMapper<BodyDto, Body>
{
    public static Body ToDomain(BodyDto dto)
        => new()
        {
            Color = new string(dto.Color),
            Height = dto.Height,
            Width = dto.Width,
            Thickness = dto.Thickness,
            Weight = dto.Weight,
            BackMaterial = Material.FromName(dto.BackMaterial).GetValueOrThrow(),
            FrameMaterial = Material.FromName(dto.FrameMaterial).GetValueOrThrow(),
            ScreenProtection = new string(dto.ScreenProtection),
            FingerprintLocation =
                FingerprintLocation.FromName(dto.FingerprintLocation).GetValueOrThrow(),
            IpRating = new string(dto.IpRating),
        };

    public static BodyDto ToDto(Body domain)
        => new()
        {
            Color = new string(domain.Color),
            Height = domain.Height,
            Width = domain.Width,
            Thickness = domain.Thickness,
            Weight = domain.Weight,
            BackMaterial = domain.BackMaterial.Name,
            FrameMaterial = domain.FrameMaterial.Name,
            ScreenProtection = new string(domain.ScreenProtection),
            FingerprintLocation = domain.FingerprintLocation.Name,
            IpRating = new string(domain.IpRating),
        };
}