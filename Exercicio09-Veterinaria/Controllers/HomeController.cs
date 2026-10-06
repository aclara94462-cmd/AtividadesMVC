using Microsoft.AspNetCore.Mvc;
namespace VeterinariaMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Veterinaria"); }
