using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{

    /// <summary>
    /// Este es un servicio de BD para los Alumnos
    /// </summary>
    public class AlumnoService : IAlumnoService
    {

        private readonly IContextDB _ContextDb;

        /// <summary>
        /// Este es el contructo de la clase
        /// </summary>
        /// <param name="contextDB"></param>
        public AlumnoService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        /// <summary>
        /// Retorna todo los alumnos 
        /// </summary>
        /// <returns></returns>
        public List<Alumno> GetAllAlumno()
        {
            return _ContextDb.Alumnos.ToList();
        }

        /// <summary>
        /// Retorna un alumno por su ID
        /// </summary>
        /// <param name="IdAlumno"></param>
        /// <returns></returns>
        public Alumno GetByIdAlumno(int IdAlumno)
        {
            return _ContextDb.Alumnos.Where(item => item.AlumnoId == IdAlumno).FirstOrDefault();
        }

        /// <summary>
        /// Agrega un alumno
        /// </summary>
        /// <param name="Alumno"></param>
        public void AddAlumno(Alumno Alumno)
        {
            _ContextDb.Alumnos.Add(Alumno);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Actualiza eun alumno
        /// </summary>
        /// <param name="Alumno"></param>
        public void UpdateAlumno(Alumno Alumno)
        {
            _ContextDb.Alumnos.Update(Alumno);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Elimina un alumno por su ID
        /// </summary>
        /// <param name="IdAlumno"></param>
        public void DeleteAlumno(int IdAlumno)
        {
            Alumno alumno = _ContextDb.Alumnos.Where(item => item.AlumnoId == IdAlumno).FirstOrDefault();
            _ContextDb.Alumnos.Remove(alumno);
            _ContextDb.SaveChanges(true);
        }

    }
}
