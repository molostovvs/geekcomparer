namespace GeekComparer.Domain.ValueObjects;

public class Core : ValueObject
{
    public int Clock { get; set; }
    public string InstructionSet { get; set; }    //TODO: implement as EnumVO?
    public string Microarchitecture { get; set; } //TODO: implement as EnumVO?
    public DateOnly LaunchDate { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Clock;
        yield return InstructionSet;
        yield return Microarchitecture;
        yield return LaunchDate;
    }
}