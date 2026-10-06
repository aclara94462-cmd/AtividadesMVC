using Microsoft.AspNetCore.Mvc;

namespace Exercicio01_Escola.Controllers;

public class EscolaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Cursos() => View();
    public IActionResult Contato() => View();
}
