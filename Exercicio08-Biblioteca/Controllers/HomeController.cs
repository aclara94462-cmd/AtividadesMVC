using Microsoft.AspNetCore.Mvc;
namespace BibliotecaMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Biblioteca"); }
