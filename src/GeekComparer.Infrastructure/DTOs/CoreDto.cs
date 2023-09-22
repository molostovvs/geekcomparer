namespace GeekComparer.Infrastructure.DTOs;

public class CoreDto
{
    public int Clock { get; set; }
    public string InstructionSet { get; set; }
    public string Microarchitecture { get; set; }
    public DateOnly LaunchDate { get; set; }
}