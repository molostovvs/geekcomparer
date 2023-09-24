namespace GeekComparer.Domain.Enums;

public class MultiSimMode : EnumValueObject<MultiSimMode, int>
{
    public static readonly MultiSimMode Standby = new(1, nameof(Standby));
    public static readonly MultiSimMode Active = new(2, nameof(Active));

    private MultiSimMode(int id, string name) : base(id, name) {}
}