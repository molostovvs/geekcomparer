namespace GeekComparer.Parser;

public interface ISmartphoneParser
{
    static abstract SmartphoneDto Parse(string url);
}