namespace GeekComparer.Domain.ValueObjects;

public class Memory : ValueObject
{
    public Ram Ram { get; set; }
    public Storage Storage { get; set; }
    public bool MemoryCardSupported { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Ram;
        yield return Storage;
        yield return MemoryCardSupported;
    }
}