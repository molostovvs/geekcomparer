namespace GeekComparer.Domain.ValueObjects;

public class BatteryLife : ValueObject
{
    public Maybe<TimeSpan> WebBrowsing { get; set; }
    public Maybe<TimeSpan> Video { get; set; }
    public Maybe<TimeSpan> Gaming { get; set; }
    public Maybe<TimeSpan> Standby { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return WebBrowsing.HasValue ? WebBrowsing.Value : TimeSpan.MinValue;
        yield return Video.HasValue ? Video.Value : TimeSpan.MinValue;
        yield return Gaming.HasValue ? Gaming.Value : TimeSpan.MinValue;
        yield return Standby.HasValue ? Standby.Value : TimeSpan.MinValue;
    }
}