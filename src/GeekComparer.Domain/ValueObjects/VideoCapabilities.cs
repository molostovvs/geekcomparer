namespace GeekComparer.Domain.ValueObjects;

public class VideoCapabilities : ValueObject
{
    public IReadOnlyList<VideoMode> Modes { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => Modes;
}