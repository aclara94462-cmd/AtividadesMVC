using Microsoft.AspNetCore.Mvc;
using AlunoMVC.Models;

namespace AlunoMVC.Controllers;

public class AlunoController : Controller
{
    private readonly List<Aluno> dados = new()
    {
        new() { Id = 1, Nome = "Ana Clara", Idade = 16, Curso = "Desenvolvimento de Sistemas" },
        new() { Id = 2, Nome = "Beatriz", Idade = 17, Curso = "Administração" },
        new() { Id = 3, Nome = "Carlos", Idade = 16, Curso = "Desenvolvimento de Sistemas" },
        new() { Id = 4, Nome = "Daniel", Idade = 17, Curso = "Eletrônica" },
        new() { Id = 5, Nome = "Eduarda", Idade = 16, Curso = "Desenvolvimento de Sistemas" },
        new() { Id = 6, Nome = "Felipe", Idade = 17, Curso = "Administração" },
        new() { Id = 7, Nome = "Gabriela", Idade = 16, Curso = "Eletrônica" },
        new() { Id = 8, Nome = "Henrique", Idade = 17, Curso = "Desenvolvimento de Sistemas" }
    };

    public IActionResult Index() => View(dados);

    public IActionResult Detalhes(int id)
    {
        var aluno = dados.FirstOrDefault(x => x.Id == id);
        return View(aluno);
    }
}
