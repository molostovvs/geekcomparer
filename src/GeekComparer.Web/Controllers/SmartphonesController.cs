using GeekComparer.Infrastructure;
using GeekComparer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GeekComparer.Web.Controllers;

public class SmartphonesController : Controller
{
    private readonly ApplicationDbContext _db;
    private readonly IMemoryCache _memoryCache; //TODO: use memory cache for caching smartphones

    public SmartphonesController(ApplicationDbContext db, IMemoryCache memoryCache)
    {
        _db = db;
        _memoryCache = memoryCache;
    }

    [HttpGet]
    public IActionResult Index(List<Guid> comparedIds)
    {
        var compared = comparedIds;

        var allSmartphones = _db.Smartphones.ToList();

        var vm = new SmartphonesViewModel();
        vm.NotCompared = allSmartphones.Where(s => !compared.Contains(s.Id)).ToList();

        foreach (var smartphoneGuid in compared)
            vm.Compared.Add(allSmartphones.First(s => s.Id == smartphoneGuid));

        return View(vm);
    }

    [HttpPost]
    public IActionResult AddToComparison(string chosen, List<Guid> comparedIds)
    {
        var splitted = chosen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var manufacturer = splitted[0]; //TODO: handle phones like Xiaomi 13 Ultra
        var brand = splitted[1];
        var model = string.Join(' ', splitted.Skip(2));

        var idToAdd = _db.Smartphones.Where(s => s.Manufacturer == manufacturer)
           .Where(s => s.Brand == brand)
           .First(s => s.Model == model)
          ?.Id;

        if (idToAdd.HasValue)
            comparedIds.Add(idToAdd.Value);

        return RedirectToAction(
            "Index",
            "Smartphones",
            new
            {
                comparedIds,
            }
        );
    }

    [HttpPost]
    public IActionResult RemoveFromComparison(List<Guid> remainingIds)
    {
        var comparedIds = remainingIds;

        return RedirectToAction(
            "Index",
            "Smartphones",
            new
            {
                comparedIds,
            }
        );
    }
}