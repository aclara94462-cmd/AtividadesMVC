using Microsoft.AspNetCore.Mvc;
using ProdutoMVC.Models;

namespace ProdutoMVC.Controllers;

public class ProdutoController : Controller
{
    private readonly List<Produto> dados = new()
    {
        new() { Id = 1, Nome = "Notebook", Categoria = "Informática", Estoque = 5, Preco = 3500m },
        new() { Id = 2, Nome = "Mouse", Categoria = "Periféricos", Estoque = 12, Preco = 80m },
        new() { Id = 3, Nome = "Teclado", Categoria = "Periféricos", Estoque = 0, Preco = 150m },
        new() { Id = 4, Nome = "Monitor", Categoria = "Informática", Estoque = 4, Preco = 900m },
        new() { Id = 5, Nome = "Headset", Categoria = "Periféricos", Estoque = 8, Preco = 220m },
        new() { Id = 6, Nome = "Webcam", Categoria = "Periféricos", Estoque = 0, Preco = 180m },
        new() { Id = 7, Nome = "SSD", Categoria = "Informática", Estoque = 7, Preco = 420m },
        new() { Id = 8, Nome = "HD externo", Categoria = "Informática", Estoque = 3, Preco = 380m },
        new() { Id = 9, Nome = "Impressora", Categoria = "Informática", Estoque = 2, Preco = 750m },
        new() { Id = 10, Nome = "Cadeira", Categoria = "Móveis", Estoque = 0, Preco = 1100m }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Disponiveis() => View(dados.Where(x => x.Estoque > 0).ToList());
}
