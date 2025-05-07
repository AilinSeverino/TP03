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
        return View("Views/Home/Index.cshtml");
    }

    public IActionResult MostrarDisco(int ID)
    {
        ViewData["ID"] = ID;
        if(GrupoDiscos.ListDiscos.ContainsKey(ID))
        {
            ViewBag.disco = GrupoDiscos.ListDiscos[ID];
            ViewBag.disco = GrupoDiscos.ListDiscos[ID].artista;
            ViewBag.disco = GrupoDiscos.ListDiscos[ID].productor;
            ViewBag.disco = GrupoDiscos.ListDiscos[ID].generoMusical;
            ViewBag.temas = GrupoDiscos.ListDiscos[ID].temas;
        }
        return View("infoDiscos");
    }
}
