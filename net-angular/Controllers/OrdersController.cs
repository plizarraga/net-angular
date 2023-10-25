using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net_angular.Models;

namespace net_angular.Controllers;

public class OrdersController : Controller
{
    private readonly ILogger<OrdersController> _logger;

    public OrdersController(ILogger<OrdersController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
