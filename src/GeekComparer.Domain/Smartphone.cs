namespace GeekComparer.Domain;

public class Smartphone : Entity
{
    public string Manufacturer { get; set; } //Xiaomi or OnePlus  or Xiaomi
    public string Brand { get; set; }        //Redmi  or OnePlus? or Xiaomi?
    public string Model { get; set; }        //K50    or 9R       or 13
    public DateOnly AnnounceDate { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public Battery Battery { get; set; }
    public Benchmark Benchmark { get; set; }
    public Body Body { get; set; }
    public IReadOnlyList<Camera> Cameras { get; set; }
    public Connectivity Connectivity { get; set; }
    public Memory Memory { get; set; }
    public Screen Screen { get; set; }
    public Security Security { get; set; }
    public IReadOnlyList<Sensor> Sensors { get; set; }
    public SoC SoC { get; set; }
    public Software Software { get; set; }
    public Sound Sound { get; set; }
    public Category Category { get; set; }
}

public class Category : EnumValueObject<Category, int>
{
    public static readonly Category Flagship = new(1, nameof(Flagship));
    public static readonly Category Mid = new(2, nameof(Mid));
    public static readonly Category Budget = new(3, nameof(Budget));

    private Category(int id, string name) : base(id, name) {}
}