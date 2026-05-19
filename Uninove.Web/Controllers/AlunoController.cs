using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Lorenna"; 
        ViewBag.Curso = "ADS"; 
        ViewBag.Semestre = "1° Semestre";
   
        return View();
    }
}