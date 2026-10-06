using Microsoft.AspNetCore.Mvc;
namespace Exercicio04_Restaurante.Controllers;
public class RestauranteController : Controller {
    public IActionResult Index() => View();
    public IActionResult Cardapio() => View();
    public IActionResult Bebidas() => View();
    public IActionResult Contato() => View();
}
