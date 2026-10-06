using Microsoft.AspNetCore.Mvc;
using CursoMVC.Models;

namespace CursoMVC.Controllers;

public class CursoController : Controller
{
    private readonly List<Curso> dados = new()
    {
        new() { Id = 1, Nome = "Desenvolvimento de Sistemas", CargaHoraria = 1200, Modalidade = "Presencial", Vagas = 20, Valor = 0m },
        new() { Id = 2, Nome = "Banco de Dados", CargaHoraria = 80, Modalidade = "Online", Vagas = 10, Valor = 250m },
        new() { Id = 3, Nome = "Cybersecurity", CargaHoraria = 100, Modalidade = "Online", Vagas = 0, Valor = 300m },
        new() { Id = 4, Nome = "Robótica", CargaHoraria = 60, Modalidade = "Presencial", Vagas = 8, Valor = 180m },
        new() { Id = 5, Nome = "Excel", CargaHoraria = 40, Modalidade = "Online", Vagas = 15, Valor = 120m },
        new() { Id = 6, Nome = "IA", CargaHoraria = 80, Modalidade = "Presencial", Vagas = 0, Valor = 350m },
        new() { Id = 7, Nome = "Git e GitHub", CargaHoraria = 30, Modalidade = "Online", Vagas = 20, Valor = 100m },
        new() { Id = 8, Nome = "C#", CargaHoraria = 90, Modalidade = "Presencial", Vagas = 12, Valor = 220m },
        new() { Id = 9, Nome = "HTML e CSS", CargaHoraria = 50, Modalidade = "Online", Vagas = 0, Valor = 150m },
        new() { Id = 10, Nome = "DevOps", CargaHoraria = 70, Modalidade = "Presencial", Vagas = 6, Valor = 280m }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Disponiveis() => View(dados.Where(x => x.Vagas > 0).ToList());
    public IActionResult Online() => View(dados.Where(x => x.Modalidade == "Online").ToList());
    public IActionResult Presenciais() => View(dados.Where(x => x.Modalidade == "Presencial").ToList());
}
