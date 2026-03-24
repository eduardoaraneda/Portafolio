using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;

        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            var modelo = new HomeIndex { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contacto (ContactoViewModel contactoViewModel)
        {
            await servicioEmail.EnviarEmail(contactoViewModel);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
