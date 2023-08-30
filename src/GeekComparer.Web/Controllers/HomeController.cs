using System.Diagnostics;
using GeekComparer.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeekComparer.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GoToSmartphone()
    {
        return RedirectToAction("Index", "Smartphones");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            }
        );
    }
}