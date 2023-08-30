using System.Collections;
using System.Reflection;
using CSharpFunctionalExtensions;

namespace GeekComparer.Infrastructure;

public static class ModelBuilderExtensions
{
    public static void SeedEnums(this ModelBuilder mb)
    {
        var smartEnums = Assembly.GetAssembly(typeof(Smartphone))
              ?.GetTypes()
               .Where(
                    t => t.BaseType is { IsGenericType: true, }
                        && t.BaseType.GetGenericTypeDefinition()
                        == typeof(EnumValueObject<,>)
                )
            ?? Enumerable.Empty<Type>();

        foreach (var smartEnum in smartEnums)
        {
            var all = smartEnum.GetField(
                        "All",
                        BindingFlags.Public
                        | BindingFlags.Static
                        | BindingFlags.FlattenHierarchy
                    )
                  ?.GetValue(null)
                ?? Enumerable.Empty<object>();

            foreach (var v in (IEnumerable)all)
                mb.Entity(smartEnum).HasData(v);
        }
    }

    public static void AddIdsToValueObjects(this ModelBuilder modelBuilder)
    {
        var vos = Assembly.GetAssembly(typeof(Smartphone))
              ?.GetTypes()
               .Where(t => t.BaseType == typeof(ValueObject))
            ?? Enumerable.Empty<Type>();

        foreach (var vo in vos)
        {
            modelBuilder.Entity(vo).Property<Guid>("Id");
            modelBuilder.Entity(vo).HasKey("Id");
        }
    }

    public static void ConfigureManyToMany(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Connectivity>().HasMany(c => c.NavigationSystems).WithMany();
        modelBuilder.Entity<Cellular>().HasMany(c => c.SimType).WithMany();
        modelBuilder.Entity<Cellular>().HasMany(c => c.Bands2G).WithMany();
        modelBuilder.Entity<Cellular>().HasMany(c => c.Bands3G).WithMany();
        modelBuilder.Entity<Cellular>().HasMany(c => c.Bands4G).WithMany();
        modelBuilder.Entity<Cellular>().HasMany(c => c.Bands5G).WithMany();
        modelBuilder.Entity<USB>().HasMany(u => u.Features).WithMany();
        modelBuilder.Entity<WiFi>().HasMany(w => w.Standards).WithMany();
        modelBuilder.Entity<Smartphone>().HasMany(s => s.Sensors).WithMany();
        modelBuilder.Entity<Sound>().HasMany(s => s.Codecs).WithMany();
        modelBuilder.Entity<Smartphone>().HasMany(s => s.Cameras).WithMany();
    }

    public static void ConfigureAutoIncludes(this ModelBuilder modelBuilder)
        => RecursiveAutoInclude(typeof(Smartphone), modelBuilder);

    private static void RecursiveAutoInclude(Type type, ModelBuilder modelBuilder)
    {
        var props = type
           .GetProperties(BindingFlags.Instance | BindingFlags.Public)
           .Where(
                p =>
                    p.PropertyType != typeof(string)
                    && (p.PropertyType.IsClass
                        || p.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
            )
           .ToList();

        foreach (var prop in props)
        {
            modelBuilder.Entity(type).Navigation(prop.Name).AutoInclude();

            if (prop.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
                RecursiveAutoInclude(
                    prop.PropertyType.GetGenericArguments().First(),
                    modelBuilder
                );
            else
                RecursiveAutoInclude(prop.PropertyType, modelBuilder);
        }
    }
}