using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{

    /// <summary>
    /// Este es un servicio de  DB para los colegios
    /// </summary>
    public class ColegioService: IColegioService
    {
        private readonly IContextDB _ContextDb;


        /// <summary>
        /// Este es el contructor de la clase
        /// </summary>
        /// <param name="contextDB"></param>
        public ColegioService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        /// <summary>
        /// Retorna todos los colegios
        /// </summary>
        /// <returns></returns>
        public List<Colegio> GetAllColegio()
        {
            return _ContextDb.Colegios.ToList();
        }
        
        /// <summary>
        /// Retorna un colegio por el ID
        /// </summary>
        /// <param name="IdColegio"></param>
        /// <returns></returns>
        public Colegio GetByIdColegio(int IdColegio)
        {
            return _ContextDb.Colegios.Where(item => item.ColegioId == IdColegio).FirstOrDefault();
        }

        /// <summary>
        /// Agrega un nuevo colegio
        /// </summary>
        /// <param name="Colegio"></param>
        public void AddColegio(Colegio Colegio)
        {
            _ContextDb.Colegios.Add(Colegio);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Actualiza un colegio
        /// </summary>
        /// <param name="Colegio"></param>
        public void UpdateColegio(Colegio Colegio)
        {
            _ContextDb.Colegios.Update(Colegio);
            _ContextDb.SaveChanges(true);
        }

        /// <summary>
        /// Elimina un colegio
        /// </summary>
        /// <param name="IdColegio"></param>
        public void DeleteColegio(int IdColegio)
        {
            Colegio Colegio = _ContextDb.Colegios.Where(item => item.ColegioId == IdColegio).FirstOrDefault();
            _ContextDb.Colegios.Remove(Colegio);
            _ContextDb.SaveChanges(true);
        }
    }
}
