using Microsoft.AspNetCore.Mvc;
namespace EstoqueMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Estoque"); }
