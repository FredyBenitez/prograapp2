using Practica01.Models;

namespace Practica01.Service
{
    public interface IStudents
    {
        public void AddStudents(Estudiantes es);
        public void UpdateStudents(Estudiantes es);
        public void DeleteStudents(Estudiantes es);
        public List<Estudiantes> GetAllStudents();
        public Estudiantes LoadInformation(Estudiantes es);
        
    }
}
