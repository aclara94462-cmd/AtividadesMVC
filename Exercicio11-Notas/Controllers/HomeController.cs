using Microsoft.AspNetCore.Mvc;
namespace AlunoNotasMVC.Controllers;
public class HomeController : Controller { public IActionResult Index() => RedirectToAction("Index", "Aluno"); }
