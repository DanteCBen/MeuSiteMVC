using MeuSiteMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuSiteMVC.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        var home = new HomeModel() { Email = "dantecosta79@gmail.com", Nome = "Dante Benicio" };

        return View(home);
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
