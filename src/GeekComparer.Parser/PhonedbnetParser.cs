using System.Globalization;
using CSharpFunctionalExtensions;

namespace GeekComparer.Parser;

public class PhonedbnetParser : ISmartphoneParser
{
    public static async Task<SmartphoneDto> Parse(string url)
    {
        var context = BrowsingContext.New(Configuration.Default.WithDefaultLoader());
        var doc = await context.OpenAsync(url);

        var rows = doc.QuerySelectorAll("tbody tr")
           .Select(
                row => new
                {
                    Key = row.QuerySelector("td:first-child"),
                    Value = row.QuerySelector("td:nth-child(2)"),
                }
            )
           .Where(t => t.Value is not null)
           .ToList();

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
                rows.First(t => t.Key?.TextContent == "Announced").Value?.TextContent,
                new DateTimeFormatInfo()
            );
        smartphone.ReleaseDate =
            DateOnly.Parse(
                rows.First(t => t.Key?.TextContent == "Released").Value?.TextContent,
                new DateTimeFormatInfo()
            );

        //TODO: parse market segment from somewhere else
        smartphone.MarketSegment = string.Empty;

        return smartphone;
    }
}