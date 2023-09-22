namespace GeekComparer.Infrastructure.Mappers;

public class CellularMapper : IMapper<CellularDto, Cellular>
{
    public static Cellular ToDomain(CellularDto dto)
        => new()
        {
            SimCount = dto.SimCount,
            MultiSimMode = MultiSimMode.FromName(dto.MultiSimMode).GetValueOrThrow(),
            SimFormats = dto.SimFormats.Select(sf => SimFormat.FromName(sf).GetValueOrThrow())
               .ToList(),
            Bands2G = dto.Bands2G.Select(b => TwoGBand.FromName(b).GetValueOrThrow()).ToList(),
            Bands3G = dto.Bands3G.Select(b => ThreeGBand.FromId(b).GetValueOrThrow()).ToList(),
            Bands4G = dto.Bands4G.Select(b => FourGBand.FromId(b).GetValueOrThrow()).ToList(),
            Bands5G = dto.Bands5G.Select(b => FiveGBand.FromId(b).GetValueOrThrow()).ToList(),
        };

    public static CellularDto ToDto(Cellular domain)
        => new()
        {
            SimCount = domain.SimCount,
            MultiSimMode = domain.MultiSimMode.Name,
            SimFormats = domain.SimFormats.Select(sf => sf.Name).ToList(),
            Bands2G = domain.Bands2G.Select(b => b.Name).ToList(),
            Bands3G = domain.Bands3G.Select(b => b.Id).ToList(),
            Bands4G = domain.Bands4G.Select(b => b.Id).ToList(),
            Bands5G = domain.Bands5G.Select(b => b.Id).ToList(),
        };
}