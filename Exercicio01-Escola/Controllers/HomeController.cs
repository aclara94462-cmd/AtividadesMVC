using Microsoft.AspNetCore.Mvc;

namespace Exercicio01_Escola.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => RedirectToAction("Index", "Escola");
}
