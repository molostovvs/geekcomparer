namespace GeekComparer.Infrastructure.DTOs;

public class CameraDto
{
    public string LensType { get; set; }  // Wide or Telephono or Ultra-wide etc
    public double Matrix { get; set; }    // 50MP -> 50 megapixels
    public double Aperture { get; set; }  // 1.9 -> f/1.9
    public int FocalLength { get; set; }  // 23 -> 23 mm
    public double PixelSize { get; set; } // 1.6 micron
    public ImageSensorDto Sensor { get; set; }
    public string Autofocus { get; set; }
    public string Stabilization { get; set; }
    public bool HasOpticalZoom { get; set; }
    public int OpticalZoomValue { get; set; } // 5x or 10x
    public int DigitalZoomValue { get; set; }
    public PhotoCapabilitiesDto PhotoCapabilities { get; set; }
    public VideoCapabilitiesDto VideoCapabilities { get; set; }
}