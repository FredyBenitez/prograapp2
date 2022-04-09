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

        public IActionResult Load(int id)
        {
            Estudiantes es = new Estudiantes();
            es.Id = id;
            var listarestudiante = Estudiante.LoadInformation(es);
            return View(listarestudiante);
        }

        public IActionResult Delete(int id)
        {
            Estudiantes es = new Estudiantes();
            es.Id = id;
            Estudiante.DeleteStudents(es);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            //Estudiantes es = new Estudiantes();
            //es.Name = "Fredy";
            //es.LastName = "Benitez";
            //Estudiante.AddStudents(es);
            var listar = Estudiante.GetAllStudents();
            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Estudiantes es)
        {

            return RedirectToAction("Index");
            // return View("Index");
        }

        public IActionResult actu(Estudiantes es)
        {
            Estudiante.UpdateStudents(es);
            return RedirectToAction("Index");
        }

        public IActionResult Guardar()
        {
            return View();
        }

        public IActionResult save(Estudiantes es)
        {
            Estudiante.AddStudents(es);
            return RedirectToAction("Index");
        }
    }

}   
