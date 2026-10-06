using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;

namespace VeterinariaMVC.Controllers;

public class VeterinariaController : Controller
{
    private readonly List<Animal> dados = new()
    {
        new() { Id = 1, Nome = "Luna", Especie = "Cachorro", Idade = 4, Dono = "Mariana" },
        new() { Id = 2, Nome = "Milo", Especie = "Gato", Idade = 2, Dono = "Rafael" },
        new() { Id = 3, Nome = "Thor", Especie = "Cachorro", Idade = 6, Dono = "Camila" },
        new() { Id = 4, Nome = "Nina", Especie = "Gato", Idade = 3, Dono = "Lucas" },
        new() { Id = 5, Nome = "Mel", Especie = "Cachorro", Idade = 1, Dono = "Julia" },
        new() { Id = 6, Nome = "Simba", Especie = "Gato", Idade = 5, Dono = "Pedro" },
        new() { Id = 7, Nome = "Bob", Especie = "Cachorro", Idade = 8, Dono = "Fernanda" },
        new() { Id = 8, Nome = "Amora", Especie = "Gato", Idade = 2, Dono = "Gustavo" }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Cachorros() => View(dados.Where(x => x.Especie == "Cachorro").ToList());
    public IActionResult Gatos() => View(dados.Where(x => x.Especie == "Gato").ToList());
}
