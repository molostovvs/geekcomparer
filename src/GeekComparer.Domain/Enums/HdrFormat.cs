namespace GeekComparer.Domain.Enums;

public class HdrFormat : EnumValueObject<HdrFormat, int>
{
    public static readonly HdrFormat HDR10 = new(1, nameof(HDR10));
    public static readonly HdrFormat DolbyVision = new(2, nameof(DolbyVision));
    public static readonly HdrFormat HDR10Plus = new(3, nameof(HDR10Plus));
    public static readonly HdrFormat HLG = new(4, nameof(HLG));

    private HdrFormat(int id, string name) : base(id, name) {}
}