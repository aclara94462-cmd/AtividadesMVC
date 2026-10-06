using Microsoft.AspNetCore.Mvc;
namespace FuncionarioMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Funcionario"); }
