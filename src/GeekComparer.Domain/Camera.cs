namespace GeekComparer.Domain;

public class Camera : ValueObject
{
    public string Name { get; set; }        // Wide or Telephono or Ultra-wide etc
    public string Location { get; set; }    // Front, back 2nd, back third etc
    public string Matrix { get; set; }      // 50 megapixels
    public string Aperture { get; set; }    // f/1.9
    public string FocalLength { get; set; } // 23 mm
    public double PixelSize { get; set; }   // 1.6 micron
    public Sensor Sensor { get; set; }
    public Autofocus Autofocus { get; set; }
    public Stabilization Stabilization { get; set; }
    public bool OpticalZoom { get; set; }
    public int OpticalZoomValue { get; set; } // 5x or 10x
    public int DigitalZoomValue { get; set; }

    public Image Image { get; set; }
    public Video Video { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
        => throw new NotImplementedException();
}

public class Video
{
    public VideoStats EightK { get; set; }
    public VideoStats FourK { get; set; }
    public VideoStats FullHD { get; set; }
    public VideoStats HD { get; set; }
}

public class VideoStats
{
    public string Resolution { get; set; }
    public int FrameRate { get; set; }
}

public class Image
{
    public int ImageWidth { get; set; }
    public int ImageHeight { get; set; }
    public string ImageResolution => ImageHeight + " x " + ImageWidth;
}

public enum Stabilization
{
    Optical, Digital,
}

public enum Autofocus {}

public class Sensor
{
    public string SomeShit { get; set; }     // 1/2.51"
    public string Manufacturer { get; set; } // SONY
    public string Model { get; set; }        //IMX858
    public string Type { get; set; }         // CMOS
}