namespace GeekComparer.Infrastructure.Mappers;

public class CoreMapper : IMapper<CoreDto, Core>
{
    public static Core ToDomain(CoreDto dto)
        => new()
        {
            Clock = dto.Clock,
            InstructionSet = new string(dto.InstructionSet),
            LaunchDate = dto.LaunchDate,
            Microarchitecture = new string(dto.Microarchitecture),
        };

    public static CoreDto ToDto(Core domain)
        => new()
        {
            Clock = domain.Clock,
            InstructionSet = new string(domain.InstructionSet),
            LaunchDate = domain.LaunchDate,
            Microarchitecture = new string(domain.Microarchitecture),
        };
}