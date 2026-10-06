using Microsoft.AspNetCore.Mvc;
namespace Exercicio05_Hotel.Controllers;
public class HotelController : Controller {
    public IActionResult Index() => View();
    public IActionResult Quartos() => View();
    public IActionResult Servicos() => View();
    public IActionResult Contato() => View();
}
