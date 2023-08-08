using GeekComparer.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeekComparer.Web.Controllers;

public class SmartphoneController : Controller
{
    private List<Smartphone> _smartphones = new List<Smartphone>
    {
        new() { Id = 1, Brand = "Apple", Model = "iPhone Xr", ReleaseDate = "May 2019" },
        new() { Id = 2, Brand = "Realme", Model = "GT Neo 5 SE", ReleaseDate = "May 2023" },
        new() { Id = 3, Brand = "OnePlus", Model = "Nord 2", ReleaseDate = "January 2022" },
        new() { Id = 4, Brand = "Xiaomi", Model = "5S", ReleaseDate = "February 2022" },
        new() { Id = 5, Brand = "Oppo", Model = "Reno 8", ReleaseDate = "March 2022" },
        new() { Id = 6, Brand = "Google", Model = "Pixel 6a", ReleaseDate = "April 2022" },
        new() { Id = 7, Brand = "Samsung", Model = "A54", ReleaseDate = "May 2022" },
        new() { Id = 8, Brand = "Nothing", Model = "Phone 2", ReleaseDate = "June 2022" },
        new() { Id = 9, Brand = "Asus", Model = "ZenPhone 8", ReleaseDate = "July 2022" },
    };

    [HttpGet("/SmartphoneCompare/{comparisonIds}")]
    public IActionResult Index(string comparisonIds)
    {
        var vm = new SmartphoneViewModel();

        vm.Smartphones = _smartphones; // DB Access imitation

        var ids = comparisonIds.Split('_').Select(i => int.Parse(i)).ToArray();

        foreach (var id in ids)
            vm.Comparison.Add(_smartphones.First(s => s.Id == id));

        return View(vm);
    }

    [HttpPost]
    public IActionResult AddToComparison(string smartphoneChoice, int[] comparisonIds)
    {
        var brand = smartphoneChoice.Split(' ')[0];
        var modelSplitted = smartphoneChoice.Split(' ').Skip(1);
        var model = string.Join(' ', modelSplitted);

        var idToAdd = _smartphones.Where(s => s.Brand == brand)
                                  .First(s => s.Model == model)
                                  .Id.ToString();

        var ids = string.Join('_', comparisonIds);
        ids += $"_{idToAdd}";

        return RedirectToAction("Index", "Smartphone", new { comparisonIds = ids });
    }

    [HttpPost]
    public IActionResult DeleteFromComparison(int idToDelete, int[] comparisonIds)
    {
        var ids = string.Join('_', comparisonIds.Where(id => id != idToDelete));

        return RedirectToAction("Index", "Smartphone", new { comparisonIds = ids });
    }
}