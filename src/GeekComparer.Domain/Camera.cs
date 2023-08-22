namespace GeekComparer.Domain;

public class Camera : ValueObject
{
    public LensType LensType { get; set; } // Wide or Telephono or Ultra-wide etc
    public double Matrix { get; set; }     // 50MP -> 50 megapixels
    public double Aperture { get; set; }   // 1.9 -> f/1.9
    public int FocalLength { get; set; }   // 23 -> 23 mm
    public double PixelSize { get; set; }  // 1.6 micron
    public ImageSensor Sensor { get; set; }
    public Autofocus Autofocus { get; set; }
    public Stabilization Stabilization { get; set; }
    public bool HasOpticalZoom { get; set; }
    public int OpticalZoomValue { get; set; } // 5x or 10x
    public int DigitalZoomValue { get; set; }

    public Photo Photo { get; set; }
    public Video Video { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class LensType : EnumValueObject<LensType, int>
{
    public static readonly LensType Normal = new(1, nameof(Normal));
    public static readonly LensType Wide = new(2, nameof(Wide));
    public static readonly LensType UltraWide = new(3, nameof(UltraWide));
    public static readonly LensType Telephoto = new(4, nameof(Telephoto));
    public static readonly LensType Depth = new(5, nameof(Depth));

    private LensType(int id, string name) : base(id, name) {}
}

public class Video : ValueObject
{
    public IReadOnlyList<Mode> Modes { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => Modes;
}

public class Mode : ValueObject
{
    public string Resolution { get; set; }
    public int FrameRate { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Resolution;
        yield return FrameRate;
    }
}

public class Photo : ValueObject
{
    public int MaxWidth { get; set; }
    public int MaxHeight { get; set; }
    public string MaxResolution => MaxHeight + " x " + MaxWidth;

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return MaxWidth;
        yield return MaxHeight;
        yield return MaxResolution;
    }
}

public class Stabilization : EnumValueObject<Stabilization, int>
{
    public static readonly Stabilization Optical = new(1, nameof(Optical));
    public static readonly Stabilization Digital = new(2, nameof(Digital));

    private Stabilization(int id, string name) : base(id, name) {}
}

public class Autofocus : EnumValueObject<Autofocus, int>
{
    public static readonly Autofocus Laser = new(1, nameof(Laser));
    public static readonly Autofocus Phase = new(2, nameof(Phase));
    public static readonly Autofocus Contrast = new(3, nameof(Contrast));

    private Autofocus(int id, string name) : base(id, name) {}
}

public class ImageSensor
{
    public string Format { get; set; }       // 1/2.51"
    public string Manufacturer { get; set; } // SONY
    public string Model { get; set; }        //IMX858
}