namespace GeekComparer.Domain;

public class Software
{
    public OperatingSystem OperatingSystem { get; set; }
    public int OperatingSystemVersion { get; set; }
    public UI UI;
    public int UIVersion { get; set; }
}

public enum UI
{
    MIUI, FunTouch, AOSP,
}

public enum OperatingSystem
{
    Android, IOS, Linux,
}