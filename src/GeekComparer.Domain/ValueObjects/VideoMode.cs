namespace GeekComparer.Domain.ValueObjects;

public class VideoMode : ValueObject
{
    public string Resolution { get; set; }
    public int FrameRate { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Resolution;
        yield return FrameRate;
    }
}