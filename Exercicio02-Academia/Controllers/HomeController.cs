using Microsoft.AspNetCore.Mvc;
namespace Exercicio02_Academia.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Academia"); }
