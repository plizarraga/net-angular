using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net_angular.Models;

namespace net_angular.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        var scriptFiles = Directory.GetFiles("wwwroot/client", "*.js")
            .Select(Path.GetFileName)
            .ToList();

        return View(scriptFiles);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
