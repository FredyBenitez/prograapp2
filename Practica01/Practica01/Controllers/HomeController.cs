using Microsoft.AspNetCore.Mvc;
using Practica01.Bussines;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
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

        //importante sin una accion no tenemos vistas
        public IActionResult Suma(Acciones acciones) {

            //if(acciones.DatoN1 > 10 || acciones.DatoN2 > 10)
            //{
            //    return View("NoMayores");
            //}
            //Double resultado = acciones.DatoN1 + acciones.DatoN2;

            //ViewBag.DatoN1V = acciones.DatoN1;
            //ViewBag.DatoN2V = acciones.DatoN2;

           //objeto de negocios
            Operaciones op = new Operaciones();

            Double resultado = op.Suma(acciones);

            ViewBag.VariableAEnviar = resultado;

            return View(); 
        }

        public IActionResult Resta(Acciones acciones)
        {


            if (acciones.DatoN1 > 10 || acciones.DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.DatoN1 - acciones.DatoN2;

            ViewBag.DatoN1V = acciones.DatoN1;
            ViewBag.DatoN2V = acciones.DatoN2;


            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Multiplicacion(Acciones acciones)
        {


            if (acciones.DatoN1 > 10 || acciones.DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.DatoN1 * acciones.DatoN2;

            ViewBag.DatoN1V = acciones.DatoN1;
            ViewBag.DatoN2V = acciones.DatoN2;


            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Division(Acciones acciones)
        {


            if (acciones.DatoN1 > 10 || acciones.DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.DatoN1 / acciones.DatoN2;

            ViewBag.DatoN1V = acciones.DatoN1;
            ViewBag.DatoN2V = acciones.DatoN2;


            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult NoMayores() { return View(); }

        [HttpGet]
        public IActionResult PeticionTypeGet()
        {
            return View();
        }
    }
}