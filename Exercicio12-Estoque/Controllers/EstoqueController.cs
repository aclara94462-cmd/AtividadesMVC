using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;

namespace EstoqueMVC.Controllers;

public class EstoqueController : Controller
{
    private readonly List<Produto> dados = new()
    {
        new() { Id = 1, Nome = "Arroz", Categoria = "Alimentos", Estoque = 0, EstoqueMinimo = 5, Preco = 25m },
        new() { Id = 2, Nome = "Feijão", Categoria = "Alimentos", Estoque = 3, EstoqueMinimo = 5, Preco = 9m },
        new() { Id = 3, Nome = "Macarrão", Categoria = "Alimentos", Estoque = 20, EstoqueMinimo = 5, Preco = 6m },
        new() { Id = 4, Nome = "Café", Categoria = "Alimentos", Estoque = 2, EstoqueMinimo = 4, Preco = 18m },
        new() { Id = 5, Nome = "Açúcar", Categoria = "Alimentos", Estoque = 15, EstoqueMinimo = 5, Preco = 5m },
        new() { Id = 6, Nome = "Farinha", Categoria = "Alimentos", Estoque = 0, EstoqueMinimo = 3, Preco = 7m },
        new() { Id = 7, Nome = "Óleo", Categoria = "Alimentos", Estoque = 8, EstoqueMinimo = 4, Preco = 8m },
        new() { Id = 8, Nome = "Sal", Categoria = "Alimentos", Estoque = 1, EstoqueMinimo = 3, Preco = 3m },
        new() { Id = 9, Nome = "Leite", Categoria = "Bebidas", Estoque = 12, EstoqueMinimo = 5, Preco = 6m },
        new() { Id = 10, Nome = "Suco", Categoria = "Bebidas", Estoque = 4, EstoqueMinimo = 4, Preco = 8m },
        new() { Id = 11, Nome = "Água", Categoria = "Bebidas", Estoque = 30, EstoqueMinimo = 10, Preco = 3m },
        new() { Id = 12, Nome = "Biscoito", Categoria = "Alimentos", Estoque = 7, EstoqueMinimo = 5, Preco = 5m },
        new() { Id = 13, Nome = "Chocolate", Categoria = "Doces", Estoque = 0, EstoqueMinimo = 4, Preco = 10m },
        new() { Id = 14, Nome = "Bolacha", Categoria = "Doces", Estoque = 6, EstoqueMinimo = 3, Preco = 5m },
        new() { Id = 15, Nome = "Bala", Categoria = "Doces", Estoque = 2, EstoqueMinimo = 5, Preco = 2m }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Baixo() => View(dados.Where(x => x.Estoque > 0 && x.Estoque <= x.EstoqueMinimo).ToList());
    public IActionResult Esgotados() => View(dados.Where(x => x.Estoque == 0).ToList());
    public IActionResult Alertas() => View(dados.Where(x => x.Estoque <= x.EstoqueMinimo).ToList());
}
