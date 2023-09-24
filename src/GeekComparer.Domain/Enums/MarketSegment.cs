namespace GeekComparer.Domain.Enums;

public class MarketSegment : EnumValueObject<MarketSegment, int>
{
    public static readonly MarketSegment Flagship = new(1, nameof(Flagship));
    public static readonly MarketSegment Mid = new(2, nameof(Mid));
    public static readonly MarketSegment Budget = new(3, nameof(Budget));

    private MarketSegment(int id, string name) : base(id, name) {}
}