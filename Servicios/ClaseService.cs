using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    /// <summary>
    /// Este es un servicio de  DB para las clases
    /// </summary>
    public class ClaseService:IClaseService
    {
        private readonly IContextDB _ContextDb;

        /// <summary>
        /// Este es el contructor de esta clase
        /// </summary>
        /// <param name="contextDB"></param>
        public ClaseService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        /// <summary>
        /// Retorna todos las clases
        /// </summary>
        /// <returns></returns>
        public List<Clase> GetAllClase()
        {
            return _ContextDb.Clases.ToList();
        }

        /// <summary>
        /// Retorna una clase por el ID
        /// </summary>
        /// <param name="IdClase"></param>
        /// <returns></returns>
        public Clase GetByIdClase(int IdClase)
        {
            return _ContextDb.Clases.Where(item => item.ClaseId == IdClase).FirstOrDefault();
        }


        /// <summary>
        /// Agrega una nueva clase
        /// </summary>
        /// <param name="Clase"></param>
        public void AddClase(Clase Clase)
        {
            _ContextDb.Clases.Add(Clase);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Actualiza una clase 
        /// </summary>
        /// <param name="Clase"></param>
        public void UpdateClase(Clase Clase)
        {
            _ContextDb.Clases.Update(Clase);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Elimina una clase por su ID
        /// </summary>
        /// <param name="IdClase"></param>
        public void DeleteClase(int IdClase)
        {
            Clase Clase = _ContextDb.Clases.Where(item => item.ClaseId == IdClase).FirstOrDefault();
            _ContextDb.Clases.Remove(Clase);
            _ContextDb.SaveChanges(true);
        }
    }
}
