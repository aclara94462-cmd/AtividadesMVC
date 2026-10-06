using Microsoft.AspNetCore.Mvc;

namespace Exercicio03_Cinema.Controllers;

public class CinemaController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Filmes()
    {
        var filmes = new List<object>
        {
            new { Nome = "Interestelar", Genero = "Ficção científica", Classificacao = "10 anos", Horario = "18:00" },
            new { Nome = "Divertida Mente 2", Genero = "Animação", Classificacao = "Livre", Horario = "14:00" },
            new { Nome = "Oppenheimer", Genero = "Drama", Classificacao = "16 anos", Horario = "20:30" },
            new { Nome = "Homem-Aranha", Genero = "Ação", Classificacao = "12 anos", Horario = "16:00" },
            new { Nome = "Moana 2", Genero = "Animação", Classificacao = "Livre", Horario = "15:30" }
        };
        return View(filmes);
    }

    public IActionResult Ingressos() => View();
}
