using GeekComparer.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeekComparer.Web.Controllers;

public class SmartphoneCompareController : Controller
{
    private List<Smartphone> _smartphones = new List<Smartphone>()
    {
        new() { Id = 1, Brand = "Apple", Model = "IPhone Xr", ReleaseDate = "May 2019" },
        new() { Id = 2, Brand = "Realme", Model = "GT Neo 5 SE", ReleaseDate = "May 2023" },
        new() { Id = 3, Brand = "OnePlus", Model = "Nord 2", ReleaseDate = "January 2022" },
        new() { Id = 4, Brand = "Xiaomi", Model = "5S", ReleaseDate = "February 2022" },
        new() { Id = 5, Brand = "Oppo", Model = "Reno 8", ReleaseDate = "March 2022" },
        new() { Id = 6, Brand = "Google", Model = "Pixel 6a", ReleaseDate = "April 2022" },
        new() { Id = 7, Brand = "Samsung", Model = "A54", ReleaseDate = "May 2022" },
        new() { Id = 8, Brand = "Nothing", Model = "Phone 2", ReleaseDate = "June 2022" },
        new() { Id = 9, Brand = "Asus", Model = "ZenPhone 8", ReleaseDate = "July 2022" },
    };

    [HttpGet]
    public IActionResult Index(SmartphoneViewModel vm)
    {
        vm.Smartphones = _smartphones;

        if (vm.Comparison.Count == 0)
            vm.Comparison = new List<Smartphone>()
            {
                new() { Id = 1, Brand = "Apple", Model = "IPhone Xr", ReleaseDate = "May 2019" },
            };

        return View(vm);
    }

    [HttpPost]
    public IActionResult AddToComparison(string smartphoneChoice, int[] comparisonIds)
    {
        var vm = new SmartphoneViewModel();
        vm.Smartphones = _smartphones;

        foreach (var id in comparisonIds)
            vm.Comparison.Add(_smartphones.First(s => s.Id == id));

        var brand = smartphoneChoice.Split(' ')[0];
        var modelSplitted = smartphoneChoice.Split(' ').Skip(1);
        var model = string.Join(' ', modelSplitted);

        vm.Comparison.Add(_smartphones.Where(s => s.Brand == brand).First(s => s.Model == model));

        return View("Index", vm);
    }

    [HttpPost]
    public IActionResult DeleteFromComparison(int idToDelete, int[] comparisonIds)
    {
        var vm = new SmartphoneViewModel();
        vm.Smartphones = _smartphones;

        foreach (var id in comparisonIds)
            vm.Comparison.Add(_smartphones.First(s => s.Id == id));

        vm.Comparison.Remove(_smartphones.First(s => s.Id == idToDelete));

        return View("Index", vm);
    }
}