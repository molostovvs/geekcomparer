namespace GeekComparer.Domain.ValueObjects;

public class Storage : ValueObject
{
    public int Size { get; set; }
    public Maybe<int> StorageVersion { get; set; }
    public StorageType Type { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Size;
        yield return Type;
        yield return StorageVersion.HasValue ? StorageVersion.Value : int.MinValue;
    }
}