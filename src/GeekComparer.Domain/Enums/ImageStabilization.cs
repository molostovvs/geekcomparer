namespace GeekComparer.Domain.Enums;

public class ImageStabilization : EnumValueObject<ImageStabilization, int>
{
    public static readonly ImageStabilization Optical = new(1, nameof(Optical));
    public static readonly ImageStabilization Digital = new(2, nameof(Digital));

    private ImageStabilization(int id, string name) : base(id, name) {}
}