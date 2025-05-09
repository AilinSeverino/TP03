using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        GrupoDiscos.InicializarDiscos();
        ViewBag.diccionario = GrupoDiscos.ListDiscos;
        return View();
    }

    public IActionResult MostrarDisco(int ID)
    {
        ViewData["ID"] = ID;
        if(GrupoDiscos.ListDiscos.ContainsKey(ID))
        {
            ViewBag.disco = GrupoDiscos.ListDiscos[ID];
            ViewBag.temas = GrupoDiscos.ListDiscos[ID].temas;
        }
        return View("infoDiscos");
    }
}
