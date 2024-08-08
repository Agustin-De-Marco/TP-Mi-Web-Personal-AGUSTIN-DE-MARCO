using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Mi_Web_Personal_AGUSTIN_DE_MARCO.Models;

namespace TP_Mi_Web_Personal_AGUSTIN_DE_MARCO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            return View();
        }

        public IActionResult Certificados()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Certificados = Datos.GetCertificados();
            return View();
        }

        public IActionResult Idiomas()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Idiomas = Datos.GetIdiomas();
            return View();
        }

        public IActionResult Proyectos()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Proyectos = Datos.GetProyectos();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { });
        }
    }
}