namespace GeekComparer.Infrastructure.Mappers;

public class StorageMapper : IMapper<StorageDto, Storage>
{
    public static Storage ToDomain(StorageDto dto)
        => new()
        {
            Size = dto.Size,
            StorageVersion = dto.StorageVersion,
            Type = StorageType.FromName(dto.Type).GetValueOrThrow(),
        };

    public static StorageDto ToDto(Storage domain)
        => new()
        {
            Size = domain.Size,
            StorageVersion = domain.StorageVersion.Value,
            Type = domain.Type.Name,
        };
}