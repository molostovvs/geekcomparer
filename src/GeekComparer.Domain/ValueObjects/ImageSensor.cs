namespace GeekComparer.Domain.ValueObjects;

public class ImageSensor : ValueObject
{
    public string Format { get; set; }       // 1/2.51"
    public string Manufacturer { get; set; } // SONY
    public string Model { get; set; }        //IMX858

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Format;
        yield return Manufacturer;
        yield return Model;
    }
}