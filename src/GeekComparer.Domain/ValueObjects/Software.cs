namespace GeekComparer.Domain.ValueObjects;

public class Software : ValueObject
{
    public Distribution Distribution { get; set; }
    public OperatingSystem OperatingSystem { get; set; }
    public int DistributionVersion { get; set; }
    public int OperatingSystemVersion { get; set; }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Distribution;
        yield return OperatingSystem;
        yield return DistributionVersion;
        yield return OperatingSystemVersion;
    }
}