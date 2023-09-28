namespace GeekComparer.Parser;

public interface ISmartphoneParser
{
    static abstract Task<SmartphoneDto> Parse(string url);
}