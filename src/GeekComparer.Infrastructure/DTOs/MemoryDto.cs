namespace GeekComparer.Infrastructure.DTOs;

public class MemoryDto
{
    public RamDto Ram { get; set; }
    public StorageDto Storage { get; set; }
    public bool MemoryCardSupported { get; set; }
}