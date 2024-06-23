using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Pedro", "230.657.976-79", "userPP@gmail.com", "Negresco");
        Cliente cliente2 = new Cliente(02, "Rodrigo", "598.573.976-89", "userRR@gmail.com", "Bug");
        Cliente cliente3 = new Cliente(01, "Lais", "230.659.970-80", "userLL@gmail.com", "Aika");
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Maria", "15.345.789/0001-60", "userMM@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Neta", "16.775.679/0002-70", "userNN@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Isabele", "45.344.777/0001-90", "userII@gmail.com");
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
