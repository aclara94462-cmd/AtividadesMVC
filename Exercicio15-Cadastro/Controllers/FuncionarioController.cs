using Microsoft.AspNetCore.Mvc;
using FuncionarioMVC.Models;

namespace FuncionarioMVC.Controllers;

public class FuncionarioController : Controller
{
    private readonly List<Funcionario> dados = new()
    {
        new() { Id = 1, Nome = "Ana", Cargo = "Desenvolvedora", Departamento = "Tecnologia", Salario = 4800m, Ativo = true },
        new() { Id = 2, Nome = "Bruno", Cargo = "Analista", Departamento = "Tecnologia", Salario = 6200m, Ativo = true },
        new() { Id = 3, Nome = "Carla", Cargo = "Assistente", Departamento = "Financeiro", Salario = 2200m, Ativo = false },
        new() { Id = 4, Nome = "Diego", Cargo = "Gerente", Departamento = "Administrativo", Salario = 7500m, Ativo = true },
        new() { Id = 5, Nome = "Elisa", Cargo = "RH", Departamento = "Recursos Humanos", Salario = 3200m, Ativo = true },
        new() { Id = 6, Nome = "Felipe", Cargo = "Designer", Departamento = "Marketing", Salario = 2700m, Ativo = false },
        new() { Id = 7, Nome = "Giovana", Cargo = "Desenvolvedora", Departamento = "Tecnologia", Salario = 5200m, Ativo = true },
        new() { Id = 8, Nome = "Henrique", Cargo = "Analista", Departamento = "Financeiro", Salario = 4100m, Ativo = true },
        new() { Id = 9, Nome = "Isabela", Cargo = "Assistente", Departamento = "Administrativo", Salario = 2400m, Ativo = false },
        new() { Id = 10, Nome = "João", Cargo = "Coordenador", Departamento = "Tecnologia", Salario = 9000m, Ativo = true },
        new() { Id = 11, Nome = "Karen", Cargo = "RH", Departamento = "Recursos Humanos", Salario = 2500m, Ativo = true },
        new() { Id = 12, Nome = "Lucas", Cargo = "Vendedor", Departamento = "Comercial", Salario = 3800m, Ativo = true },
        new() { Id = 13, Nome = "Marina", Cargo = "Gerente", Departamento = "Comercial", Salario = 6500m, Ativo = false },
        new() { Id = 14, Nome = "Nicolas", Cargo = "Desenvolvedor", Departamento = "Tecnologia", Salario = 2100m, Ativo = true },
        new() { Id = 15, Nome = "Olivia", Cargo = "Analista", Departamento = "Marketing", Salario = 5500m, Ativo = true }
    };

    public IActionResult Index() => View(dados);
    public IActionResult Ativos() => View(dados.Where(x => x.Ativo).ToList());
    public IActionResult Inativos() => View(dados.Where(x => !x.Ativo).ToList());
    public IActionResult Departamento(string nome = "Tecnologia") => View(dados.Where(x => x.Departamento == nome).ToList());
    public IActionResult Dashboard() => View(dados);
}
