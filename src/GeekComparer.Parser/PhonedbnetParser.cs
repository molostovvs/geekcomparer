using System.Globalization;
using AngleSharp.Dom;

namespace GeekComparer.Parser;

public class PhonedbnetParser : ISmartphoneParser
{
    internal class Row
    {
        public IElement? Key { get; set; }
        public IElement? Value { get; set; }

        public Row(IElement key, IElement value)
        {
            Key = key;
            Value = value;
        }

        public Row() {}
    }

    public static SmartphoneDto Parse(string url)
    {
        var context = BrowsingContext.New(Configuration.Default.WithDefaultLoader());
        var doc = context.OpenAsync(url).Result;

        var rows = doc.QuerySelectorAll("tbody tr")
           .Select(
                row => new Row
                {
                    Key = row.QuerySelector("td:first-child"),
                    Value = row.QuerySelector("td:nth-child(2)"),
                }
            )
           .Where(t => t.Value is not null)
           .ToList();

        var smartphone = ParseSmartphoneData(rows);

        return smartphone;
    }

    private static SmartphoneDto ParseSmartphoneData(List<Row> rows)
    {
        var smartphone = new SmartphoneDto();

        smartphone.Id = Guid.Empty;
        smartphone.Manufacturer =
            rows.First(t => t.Key?.TextContent == "Hardware Designer").Value?.TextContent
            ?? throw new Exception();
        smartphone.Brand = rows.First(t => t.Key?.TextContent == "Brand").Value?.TextContent
            ?? throw new Exception();
        smartphone.Model = rows.First(t => t.Key?.TextContent == "Model").Value?.TextContent
            ?? throw new Exception();
        smartphone.AnnounceDate =
            DateOnly.Parse(
                (string)rows.First(t => t.Key?.TextContent == "Announced").Value?.TextContent,
                new DateTimeFormatInfo()
            );
        smartphone.ReleaseDate =
            DateOnly.Parse(
                (string)rows.First(t => t.Key?.TextContent == "Released").Value?.TextContent,
                new DateTimeFormatInfo()
            );

        //TODO: parse market segment from somewhere else
        smartphone.MarketSegment = string.Empty;

        var battery = new BatteryDto();

        battery.Capacity =
            int.Parse(
                rows.First(r => r.Key.TextContent.Contains("Nominal Battery Capacity"))
                   .Value?.TextContent.Split(" ")[0]
            );

        battery.Replaceable = rows.First(
                r => r.Key?.TextContent == string.Empty && (r.Value.TextContent == "built-in"
                    || r.Value.TextContent == "removable")
            )
           .Value.TextContent == "removable";

        smartphone.Battery = battery;

        return smartphone;
    }
}