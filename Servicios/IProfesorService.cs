using CursoEFCore.Modelos;
using System.Collections.Generic;

namespace CursoEFCore.Servicios
{
    public interface IProfesorService
    {

        public List<Profesor> GetAllProfesor();

        public Profesor GetByIdProfesor(int IdAlumno);

        public void AddProfesor(Profesor Profesor);

        public void UpdateProfesor(Profesor Profesor);

        public void DeleteProfesor(int IdProfesor);

    }
}
