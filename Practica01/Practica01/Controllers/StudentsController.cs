using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Repository;
using Practica01.Service;

namespace Practica01.Controllers
{
    public class StudentsController : Controller
    {
        private IStudents Estudiante;

        public StudentsController(IStudents estudiante)
        {
            Estudiante = estudiante;
        }

        public IActionResult Index()
        {
            Estudiantes es = new Estudiantes();
            es.Name = "Fredy";
            es.LastName = "Benitez";
            Estudiante.AddStudents(es);
            return View();
        }
    }
}
