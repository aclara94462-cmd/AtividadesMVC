using Microsoft.AspNetCore.Mvc;
using PedidoMVC.Models;

namespace PedidoMVC.Controllers;

public class PedidoController : Controller
{
    private readonly List<Pedido> dados = new()
    {
        new() { Id = 1, Cliente = "Ana", Produto = "X-Burguer", Quantidade = 1, PrecoUnitario = 22m, Status = "Recebido" },
        new() { Id = 2, Cliente = "Bruno", Produto = "Batata", Quantidade = 2, PrecoUnitario = 12m, Status = "Em preparo" },
        new() { Id = 3, Cliente = "Carla", Produto = "Pizza", Quantidade = 1, PrecoUnitario = 40m, Status = "Pronto" },
        new() { Id = 4, Cliente = "Diego", Produto = "Suco", Quantidade = 2, PrecoUnitario = 8m, Status = "Entregue" },
        new() { Id = 5, Cliente = "Elisa", Produto = "X-Salada", Quantidade = 1, PrecoUnitario = 25m, Status = "Recebido" },
        new() { Id = 6, Cliente = "Felipe", Produto = "Pizza", Quantidade = 2, PrecoUnitario = 40m, Status = "Em preparo" },
        new() { Id = 7, Cliente = "Giovana", Produto = "Açaí", Quantidade = 1, PrecoUnitario = 18m, Status = "Pronto" },
        new() { Id = 8, Cliente = "Henrique", Produto = "Hambúrguer", Quantidade = 2, PrecoUnitario = 28m, Status = "Entregue" },
        new() { Id = 9, Cliente = "Isabela", Produto = "Coxinha", Quantidade = 4, PrecoUnitario = 7m, Status = "Recebido" },
        new() { Id = 10, Cliente = "João", Produto = "Refrigerante", Quantidade = 3, PrecoUnitario = 7m, Status = "Em preparo" }
    };

    public IActionResult Index() => View(dados);
    public IActionResult EmPreparo() => View(dados.Where(x => x.Status == "Em preparo").ToList());
    public IActionResult Prontos() => View(dados.Where(x => x.Status == "Pronto").ToList());
    public IActionResult Entregues() => View(dados.Where(x => x.Status == "Entregue").ToList());
    public IActionResult Dashboard() => View(dados);
}
