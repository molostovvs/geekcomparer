namespace GeekComparer.Infrastructure.DTOs;

public class SecurityDto
{
    public bool HasFaceUnlock { get; set; }
    public bool HasFingerprintUnlock { get; set; }
    public bool HasIrisUnlock { get; set; }
    public bool HasCoprocessor { get; set; }
}