namespace GeekComparer.Infrastructure.Mappers;

public class MemoryMapper : IMapper<MemoryDto, Memory>
{
    public static Memory ToDomain(MemoryDto dto)
        => new()
        {
            MemoryCardSupported = dto.MemoryCardSupported,
            Ram = RamMapper.ToDomain(dto.Ram),
            Storage = StorageMapper.ToDomain(dto.Storage),
        };

    public static MemoryDto ToDto(Memory domain)
        => new()
        {
            MemoryCardSupported = domain.MemoryCardSupported,
            Ram = RamMapper.ToDto(domain.Ram),
            Storage = StorageMapper.ToDto(domain.Storage),
        };
}