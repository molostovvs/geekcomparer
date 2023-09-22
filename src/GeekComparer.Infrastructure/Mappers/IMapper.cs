namespace GeekComparer.Infrastructure.Mappers;

public interface IMapper<TDto, TDomain>
{
    public static abstract TDomain ToDomain(TDto dto);
    public static abstract TDto ToDto(TDomain domain);
}