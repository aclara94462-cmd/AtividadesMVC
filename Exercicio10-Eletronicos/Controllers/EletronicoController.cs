using Microsoft.AspNetCore.Mvc;
using EletronicoMVC.Models;

namespace EletronicoMVC.Controllers;

public class EletronicoController : Controller
{
    private readonly List<Eletronico> dados = new()
    {
        new() { Id = 1, Nome = "Notebook", Marca = "Lenovo", Categoria = "Informática", Preco = 3500m, Estoque = 4 },
        new() { Id = 2, Nome = "Smartphone", Marca = "Samsung", Categoria = "Celular", Preco = 1800m, Estoque = 8 },
        new() { Id = 3, Nome = "TV 50"", Marca = "LG", Categoria = "Televisão", Preco = 2600m, Estoque = 3 },
        new() { Id = 4, Nome = "Tablet", Marca = "Samsung", Categoria = "Informática", Preco = 950m, Estoque = 5 },
        new() { Id = 5, Nome = "Fone Bluetooth", Marca = "JBL", Categoria = "Áudio", Preco = 350m, Estoque = 10 },
        new() { Id = 6, Nome = "Monitor", Marca = "AOC", Categoria = "Informática", Preco = 850m, Estoque = 0 },
        new() { Id = 7, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4200m, Estoque = 2 },
        new() { Id = 8, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Wearables", Preco = 600m, Estoque = 6 },
        new() { Id = 9, Nome = "Câmera", Marca = "Canon", Categoria = "Fotografia", Preco = 2900m, Estoque = 1 },
        new() { Id = 10, Nome = "Teclado", Marca = "Logitech", Categoria = "Informática", Preco = 280m, Estoque = 0 },
        new() { Id = 11, Nome = "Mouse", Marca = "Logitech", Categoria = "Informática", Preco = 120m, Estoque = 15 },
        new() { Id = 12, Nome = "Caixa de som", Marca = "JBL", Categoria = "Áudio", Preco = 500m, Estoque = 7 }
    };

    public IActionResult Index() => View(dados);
    public IActionResult EmEstoque() => View(dados.Where(x => x.Estoque > 0).ToList());
    public IActionResult Categoria(string categoria = "Informática") => View(dados.Where(x => x.Categoria == categoria).ToList());
    public IActionResult AbaixoDe(decimal valor = 1000) => View(dados.Where(x => x.Preco < valor).ToList());
}
