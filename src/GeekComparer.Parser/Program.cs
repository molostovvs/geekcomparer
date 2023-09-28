using CSharpFunctionalExtensions;
using GeekComparer.Parser;

/*var config = Configuration.Default.WithDefaultLoader();
var address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
var context = BrowsingContext.New(config);
var document = await context.OpenAsync(address);
var cellSelector = "tr.vevent td:nth-child(3)";
var cells = document.QuerySelectorAll(cellSelector);
var titles = cells.Select(m => m.TextContent);*/

const string address =
    "https://phonedb.net/index.php?m=device&id=14162&c=apple_iphone_xr_a2105_global_td-lte_64gb__apple_iphone_11,8";

var dto = await PhonedbnetParser.Parse(address);

dto.GetHashCode();