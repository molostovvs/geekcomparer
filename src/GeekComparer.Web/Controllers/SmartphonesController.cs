using System.Text.Json;
using GeekComparer.Infrastructure;
using GeekComparer.Infrastructure.DTOs;
using GeekComparer.Infrastructure.Mappers;
using GeekComparer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace GeekComparer.Web.Controllers;

public class SmartphonesController : Controller
{
    private readonly ApplicationDbContext _db;
    private readonly IDistributedCache _cache;

    public SmartphonesController(ApplicationDbContext db, IDistributedCache cache)
    {
        _db = db;
        _cache = cache;
    }

    [HttpGet]
    public IActionResult Index(List<Guid> comparedIds)
    {
        if (comparedIds.Count == 0)
            return RedirectToAction("AddFirst");

        var vm = new SmartphonesViewModel();

        var cachedAllSmartphonesJson = _cache.GetString("all.smartphones:");

        if (!string.IsNullOrEmpty(cachedAllSmartphonesJson))
        {
            //TODO: exclude smartphones that are already in the comparison
            vm.NotCompared = JsonSerializer.Deserialize<List<string>>(cachedAllSmartphonesJson)!;
        }
        else
        {
            vm.NotCompared = _db.Smartphones.AsNoTracking()
               .IgnoreAutoIncludes()
               .Select(
                    sm => sm.Manufacturer
                        + " "
                        + (sm.Brand == sm.Manufacturer ? string.Empty
                            : sm.Brand + " ")
                        + sm.Model
                )
               .ToList();

            _cache.SetString(
                "all.smartphones:",
                JsonSerializer.Serialize(vm.NotCompared),
                new DistributedCacheEntryOptions { SlidingExpiration = TimeSpan.FromMinutes(20), }
            );
        }

        foreach (var comparedId in comparedIds)
        {
            var cachedSmartphoneJson = _cache.GetString(comparedId + ":");

            if (!string.IsNullOrEmpty(cachedSmartphoneJson))
            {
                var cachedSmartphone =
                    JsonSerializer.Deserialize<SmartphoneDto>(cachedSmartphoneJson);

                if (cachedSmartphone is not null)
                    vm.Compared.Add(cachedSmartphone);
            }
            else
            {
                var smartphone = SmartphoneMapper.ToDto(
                    _db.Smartphones.AsNoTracking().First(sm => sm.Id == comparedId)
                );

                vm.Compared.Add(smartphone);

                _cache.SetString(
                    comparedId + ":",
                    JsonSerializer.Serialize(smartphone),
                    new DistributedCacheEntryOptions
                        { SlidingExpiration = TimeSpan.FromMinutes(20), }
                );
            }
        }

        return View(vm);
    }

    [HttpGet]
    public IActionResult AddFirst()
    {
        List<string> list;

        var cachedAllSmartphonesJson = _cache.GetString("all.smartphones:");

        if (!string.IsNullOrEmpty(cachedAllSmartphonesJson))
        {
            list = JsonSerializer.Deserialize<List<string>>(cachedAllSmartphonesJson)!;
        }
        else
        {
            list = _db.Smartphones.AsNoTracking()
               .IgnoreAutoIncludes()
               .ToList()
               .Select(
                    sm => sm.Manufacturer
                        + " "
                        + (sm.Brand == sm.Manufacturer ? string.Empty
                            : sm.Brand + " ")
                        + sm.Model
                )
               .ToList();

            _cache.SetString("all.smartphones:", JsonSerializer.Serialize(list));
        }

        return View(list);
    }

    [HttpPost]
    public IActionResult AddToComparison(string chosen, HashSet<Guid> comparedIds)
    {
        var splitted = chosen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var manufacturer = splitted[0];
        var brand = splitted[1];
        var model = string.Join(' ', splitted.Skip(2));

        var possible = _db.Smartphones.AsNoTracking()
           .IgnoreAutoIncludes()
           .Where(sm => sm.Manufacturer == manufacturer && sm.Brand == brand)
           .ToList();

        if (possible.Count == 0)
        {
            brand = manufacturer;
            model = string.Join(' ', splitted.Skip(1));
        }

        var idToAdd = _db.Smartphones.AsNoTracking()
           .IgnoreAutoIncludes()
           .FirstOrDefault(
                s => s.Manufacturer == manufacturer && s.Brand == brand && s.Model == model
            )
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