using CursoEFCore.Modelos;
using System.Collections.Generic;

namespace CursoEFCore.Servicios
{
    public interface IAlumnoService
    {
        public List<Alumno> GetAllAlumno();

        public Alumno GetByIdAlumno(int IdAlumno);

        public void AddAlumno(Alumno Alumno);

        public void UpdateAlumno(Alumno Alumno);

        public void DeleteAlumno(int IdAlumno);
    }
}
