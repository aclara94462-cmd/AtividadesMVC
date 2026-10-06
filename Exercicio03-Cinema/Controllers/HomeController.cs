using Microsoft.AspNetCore.Mvc;
namespace Exercicio03_Cinema.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Cinema"); }
