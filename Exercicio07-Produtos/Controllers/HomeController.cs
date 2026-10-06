using Microsoft.AspNetCore.Mvc;
namespace ProdutoMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Produto"); }
