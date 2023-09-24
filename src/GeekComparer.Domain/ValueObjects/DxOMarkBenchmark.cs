namespace GeekComparer.Domain.ValueObjects;

public class DxOMarkBenchmark : ValueObject
{
    public int Photo { get; set; }
    public int Video { get; set; }
    public int Zoom { get; set; }
    public int Bokeh { get; set; }
    public int Preview { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Photo;
        yield return Video;
        yield return Zoom;
        yield return Bokeh;
        yield return Preview;
    }
}