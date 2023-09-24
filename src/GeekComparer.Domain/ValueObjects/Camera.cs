namespace GeekComparer.Domain.ValueObjects;

public class Camera : ValueObject
{
    public LensType LensType { get; set; } // Wide or Telephono or Ultra-wide etc
    public double Matrix { get; set; }     // 50MP -> 50 megapixels
    public double Aperture { get; set; }   // 1.9 -> f/1.9
    public int FocalLength { get; set; }   // 23 -> 23 mm
    public double PixelSize { get; set; }  // 1.6 micron
    public ImageSensor Sensor { get; set; }
    public Autofocus Autofocus { get; set; }
    public ImageStabilization ImageStabilization { get; set; }
    public bool HasOpticalZoom { get; set; }
    public int OpticalZoomValue { get; set; } // 5x or 10x
    public int DigitalZoomValue { get; set; }
    public PhotoCapabilities PhotoCapabilities { get; set; }
    public VideoCapabilities VideoCapabilities { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return LensType;
        yield return Matrix;
        yield return Aperture;
        yield return FocalLength;
        yield return PixelSize;
        yield return Sensor;
        yield return Autofocus;
        yield return ImageStabilization;
        yield return HasOpticalZoom;
        yield return OpticalZoomValue;
        yield return DigitalZoomValue;
        yield return PhotoCapabilities;
        yield return VideoCapabilities;
    }
}