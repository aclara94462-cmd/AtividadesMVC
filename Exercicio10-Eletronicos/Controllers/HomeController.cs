using Microsoft.AspNetCore.Mvc;
namespace EletronicoMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Eletronico"); }
