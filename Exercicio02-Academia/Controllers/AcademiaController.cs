using Microsoft.AspNetCore.Mvc;

namespace Exercicio02_Academia.Controllers;

public class AcademiaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Musculacao() => View();
    public IActionResult Cardio() => View();
    public IActionResult Planos() => View();
}
