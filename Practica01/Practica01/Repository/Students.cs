using Practica01.Data;
using Practica01.Models;
using Practica01.Service;

namespace Practica01.Repository
{
    public class Students: IStudents
    {
        private ApplicationDBContext app;

        public Students(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudents(Estudiantes es)
        {
            app.Estudiantes.Add(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteStudents(Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

      

        public List<Estudiantes> GetAllStudents()
        {
            return app.Estudiantes.ToList();
            //throw new NotImplementedException();
        }

        public Estudiantes LoadInformation(Estudiantes es)
        {
            var listarestudiante = app.Estudiantes.Where(y=>y.Id == es.Id).FirstOrDefault();
            return listarestudiante;
        }

        public void UpdateStudents(Estudiantes es)
        {
            app.Estudiantes.Update(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
