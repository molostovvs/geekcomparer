namespace GeekComparer.Domain.Enums;

public class ThreeGBand : EnumValueObject<ThreeGBand, int>
{
    public static readonly ThreeGBand One = new(1, nameof(One));
    public static readonly ThreeGBand Two = new(2, nameof(Two));
    public static readonly ThreeGBand Three = new(3, nameof(Three));
    public static readonly ThreeGBand Four = new(4, nameof(Four));
    public static readonly ThreeGBand Five = new(5, nameof(Five));
    public static readonly ThreeGBand Six = new(6, nameof(Six));
    public static readonly ThreeGBand Seven = new(7, nameof(Seven));
    public static readonly ThreeGBand Eight = new(8, nameof(Eight));
    public static readonly ThreeGBand Nine = new(9, nameof(Nine));
    public static readonly ThreeGBand Ten = new(10, nameof(Ten));
    public static readonly ThreeGBand Eleven = new(11, nameof(Eleven));
    public static readonly ThreeGBand Twelve = new(12, nameof(Twelve));
    public static readonly ThreeGBand Thirteen = new(13, nameof(Thirteen));
    public static readonly ThreeGBand Fourteen = new(14, nameof(Fourteen));
    public static readonly ThreeGBand Nineteen = new(19, nameof(Nineteen));
    public static readonly ThreeGBand Twenty = new(20, nameof(Twenty));
    public static readonly ThreeGBand TwentyOne = new(21, nameof(TwentyOne));
    public static readonly ThreeGBand TwentyTwo = new(22, nameof(TwentyTwo));
    public static readonly ThreeGBand TwentyFive = new(25, nameof(TwentyFive));
    public static readonly ThreeGBand TwentySix = new(26, nameof(TwentySix));
    public static readonly ThreeGBand ThirtyTwo = new(32, nameof(ThirtyTwo));

    public static readonly ThreeGBand A = new(101, nameof(A));
    public static readonly ThreeGBand B = new(102, nameof(B));
    public static readonly ThreeGBand C = new(103, nameof(C));
    public static readonly ThreeGBand D = new(104, nameof(D));
    public static readonly ThreeGBand E = new(105, nameof(E));
    public static readonly ThreeGBand F = new(106, nameof(F));

    private ThreeGBand(int id, string name) : base(id, name) {}
}