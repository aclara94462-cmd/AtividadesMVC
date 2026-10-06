using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers;

public class BibliotecaController : Controller
{
    private readonly List<Livro> dados = new()
    {
        new() { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Ano = 1899, Disponivel = true },
        new() { Id = 2, Titulo = "O Cortiço", Autor = "Aluísio Azevedo", Ano = 1890, Disponivel = false },
        new() { Id = 3, Titulo = "Orgulho e Preconceito", Autor = "Jane Austen", Ano = 1813, Disponivel = true },
        new() { Id = 4, Titulo = "Os Miseráveis", Autor = "Victor Hugo", Ano = 1862, Disponivel = false },
        new() { Id = 5, Titulo = "Frankenstein", Autor = "Mary Shelley", Ano = 1818, Disponivel = true },
        new() { Id = 6, Titulo = "1984", Autor = "George Orwell", Ano = 1949, Disponivel = true },
        new() { Id = 7, Titulo = "A Revolução dos Bichos", Autor = "George Orwell", Ano = 1945, Disponivel = false },
        new() { Id = 8, Titulo = "Jane Eyre", Autor = "Charlotte Brontë", Ano = 1847, Disponivel = true },
        new() { Id = 9, Titulo = "Grande Sertão: Veredas", Autor = "Guimarães Rosa", Ano = 1956, Disponivel = true },
        new() { Id = 10, Titulo = "A Hora da Estrela", Autor = "Clarice Lispector", Ano = 1977, Disponivel = false }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Disponiveis() => View(dados.Where(x => x.Disponivel).ToList());
}
