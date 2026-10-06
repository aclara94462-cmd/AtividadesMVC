using Microsoft.AspNetCore.Mvc;
namespace Exercicio04_Restaurante.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Restaurante"); }
