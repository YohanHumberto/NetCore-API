using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    /// <summary>
    /// Este es un servicio de DB par los Profesores
    /// </summary>
    public class ProfesorService: IProfesorService
    {
        private readonly IContextDB _ContextDb;

        /// <summary>
        /// Este es el contructor
        /// </summary>
        /// <param name="contextDB"></param>
        public ProfesorService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        /// <summary>
        /// Retorna todos los profesores
        /// </summary>
        /// <returns></returns>
        public List<Profesor> GetAllProfesor()
        {
            return _ContextDb.Profesores.ToList();
        }

        /// <summary>
        /// Retorna un profesor por ID
        /// </summary>
        /// <param name="IdProfesores"></param>
        /// <returns></returns>
        public Profesor GetByIdProfesor(int IdProfesores)
        {
            return _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
        }

        /// <summary>
        /// Agrega un nuevo profesor 
        /// </summary>
        /// <param name="Profesores"></param>
        public void AddProfesor(Profesor Profesores)
        {
            _ContextDb.Profesores.Add(Profesores);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Actualiza un profesor
        /// </summary>
        /// <param name="Profesores"></param>
        public void UpdateProfesor(Profesor Profesores)
        {
            _ContextDb.Profesores.Update(Profesores);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Elimina un profesor por el ID
        /// </summary>
        /// <param name="IdProfesores"></param>
        public void DeleteProfesor(int IdProfesores)
        {
            Profesor Profesores = _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
            _ContextDb.Profesores.Remove(Profesores);
            _ContextDb.SaveChanges(true);
        }
    }
}
