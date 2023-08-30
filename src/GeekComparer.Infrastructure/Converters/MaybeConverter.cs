using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GeekComparer.Infrastructure.Converters;

public class MaybeConverter<T> : ValueConverter<Maybe<T>, T>
{
    public MaybeConverter() : base(
        maybe => maybe.GetValueOrDefault(default),
        t => Maybe.From(t)
    ) {}
}