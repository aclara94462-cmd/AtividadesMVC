using Microsoft.AspNetCore.Mvc;
namespace CursoMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Curso"); }
