using Microsoft.AspNetCore.Mvc;
using AlunoNotasMVC.Models;

namespace AlunoNotasMVC.Controllers;

public class AlunoController : Controller
{
    private readonly List<Aluno> dados = new()
    {
        new() { Id = 1, Nome = "Ana", Curso = "DS", Nota1 = 8, Nota2 = 7, Nota3 = 9 },
        new() { Id = 2, Nome = "Bruno", Curso = "DS", Nota1 = 5, Nota2 = 4, Nota3 = 5 },
        new() { Id = 3, Nome = "Carla", Curso = "Administração", Nota1 = 3, Nota2 = 2, Nota3 = 3 },
        new() { Id = 4, Nome = "Diego", Curso = "DS", Nota1 = 6, Nota2 = 6, Nota3 = 7 },
        new() { Id = 5, Nome = "Elisa", Curso = "Administração", Nota1 = 9, Nota2 = 8, Nota3 = 10 },
        new() { Id = 6, Nome = "Felipe", Curso = "DS", Nota1 = 4, Nota2 = 5, Nota3 = 4 },
        new() { Id = 7, Nome = "Giovana", Curso = "DS", Nota1 = 2, Nota2 = 3, Nota3 = 3 },
        new() { Id = 8, Nome = "Henrique", Curso = "Administração", Nota1 = 7, Nota2 = 6, Nota3 = 8 },
        new() { Id = 9, Nome = "Isabela", Curso = "DS", Nota1 = 5, Nota2 = 5, Nota3 = 6 },
        new() { Id = 10, Nome = "João", Curso = "DS", Nota1 = 10, Nota2 = 9, Nota3 = 9 }
    };

    private static double Media(Aluno aluno) => (aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3;

    public IActionResult Index() => View(dados);
    public IActionResult Aprovados() => View(dados.Where(x => Media(x) >= 6).ToList());
    public IActionResult Recuperacao() => View(dados.Where(x => Media(x) >= 4 && Media(x) < 6).ToList());
    public IActionResult Reprovados() => View(dados.Where(x => Media(x) < 4).ToList());
}
