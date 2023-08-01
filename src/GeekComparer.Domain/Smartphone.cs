namespace GeekComparer.Domain;

public class Smartphone : Entity
{
    public Release Release { get; set; }
    public string Manufacturer { get; set; }
    public Body Body { get; set; }
    public Battery Battery { get; set; }
    public Benchmark Benchmark { get; set; }
    public IReadOnlyList<Camera> Cameras { get; set; }
    public Connectivity Connectivity { get; set; }
    public Memory Memory { get; set; }
    public Screen Screen { get; set; }
    public Sensors Sensors { get; set; }
    public SoC SoC { get; set; }
    public Software Software { get; set; }
    public Sound Sound { get; set; }
}

public enum Category
{
    Flagship, Mid, Economy
}

public class Release
{
    public DateOnly Date { get; set; }     // 05.05.2015
    public Category Category { get; set; } // Flagship
    public string Brand { get; set; }      // iPhone
    public string Model { get; set; }      // Xr
}