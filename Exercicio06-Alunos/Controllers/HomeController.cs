using Microsoft.AspNetCore.Mvc;
namespace AlunoMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Aluno"); }
