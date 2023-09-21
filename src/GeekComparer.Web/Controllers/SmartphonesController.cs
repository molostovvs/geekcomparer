using GeekComparer.Infrastructure;
using GeekComparer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        if (comparedIds.Count == 0)
            return RedirectToAction("AddFirst");

        var allSmartphones = _db.Smartphones.ToList();

        var vm = new SmartphonesViewModel();
        vm.NotCompared = allSmartphones.Where(s => !comparedIds.Contains(s.Id)).ToList();

        foreach (var smartphoneGuid in comparedIds)
            vm.Compared.Add(allSmartphones.First(s => s.Id == smartphoneGuid));

        return View(vm);
    }

    [HttpGet]
    public IActionResult AddFirst()
    {
        var smartphones = _db.Smartphones.ToList();

        return View(smartphones);
    }

    [HttpPost]
    public IActionResult AddToComparison(string chosen, List<Guid> comparedIds)
    {
        var splitted = chosen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var manufacturer = splitted[0]; //TODO: handle phones like Xiaomi 13 Ultra
        var brand = splitted[1];
        var model = string.Join(' ', splitted.Skip(2));

        var possible = _db.Smartphones.IgnoreAutoIncludes()
           .Where(sm => sm.Manufacturer == manufacturer)
           .Where(sm => sm.Brand == brand).ToList();

        if (possible.Count == 0)
        {
            brand = manufacturer;
            model = string.Join(' ', splitted.Skip(1));
        }


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