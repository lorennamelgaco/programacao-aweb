using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Sobre()
    {
         return View();
    }

    public IActionResult Boletim()
    {
        var disciplinas = new List<string> { "Desenv Web", "Arquitetura", "Internet das Coisas", "FrontEnd" };
    var notas = new List<double> { 9.5, 6.0, 7.5, 8.0 };

    ViewBag.Disciplinas = disciplinas;
    ViewBag.Notas = notas;

    return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
