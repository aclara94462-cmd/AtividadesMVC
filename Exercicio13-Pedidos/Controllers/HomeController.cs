using Microsoft.AspNetCore.Mvc;
namespace PedidoMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Pedido"); }
