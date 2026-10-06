using Microsoft.AspNetCore.Mvc;
namespace Exercicio05_Hotel.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Hotel"); }
