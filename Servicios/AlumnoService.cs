using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    public class AlumnoService : IAlumnoService
    {

        private readonly IContextDB _ContextDb;

        public AlumnoService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        public List<Alumno> GetAllAlumno()
        {
            return _ContextDb.Alumnos.ToList();
        }

        public Alumno GetByIdAlumno(int IdAlumno)
        {
            return _ContextDb.Alumnos.Where(item => item.AlumnoId == IdAlumno).FirstOrDefault();
        }

        public void AddAlumno(Alumno Alumno)
        {
            _ContextDb.Alumnos.Add(Alumno);
            _ContextDb.SaveChanges(true);
        }

        public void UpdateAlumno(Alumno Alumno)
        {
            _ContextDb.Alumnos.Update(Alumno);
            _ContextDb.SaveChanges(true);
        }

        public void DeleteAlumno(int IdAlumno)
        {
            Alumno alumno = _ContextDb.Alumnos.Where(item => item.AlumnoId == IdAlumno).FirstOrDefault();
            _ContextDb.Alumnos.Remove(alumno);
            _ContextDb.SaveChanges(true);
        }

    }
}
