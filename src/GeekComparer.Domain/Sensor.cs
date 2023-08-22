namespace GeekComparer.Domain;

public class Sensor : EnumValueObject<Sensor, int>
{
    public static readonly Sensor Barometer = new(1, nameof(Barometer));
    public static readonly Sensor Proximity = new(2, nameof(Proximity));
    public static readonly Sensor Gyroscope = new(3, nameof(Gyroscope));
    public static readonly Sensor Accelerometer = new(4, nameof(Accelerometer));
    public static readonly Sensor Photo = new(5, nameof(Photo));               //light sensor
    public static readonly Sensor Magnetometer = new(6, nameof(Magnetometer)); //for compass
    public static readonly Sensor GPS = new(7, nameof(GPS));
    public static readonly Sensor LIDAR = new(8, nameof(LIDAR));

    private Sensor(int id, string name) : base(id, name) {}
}