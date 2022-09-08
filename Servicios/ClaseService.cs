using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    public class ClaseService:IClaseService
    {
        private readonly IContextDB _ContextDb;

        public ClaseService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        public List<Clase> GetAllClase()
        {
            return _ContextDb.Clases.ToList();
        }

        public Clase GetByIdClase(int IdClase)
        {
            return _ContextDb.Clases.Where(item => item.ClaseId == IdClase).FirstOrDefault();
        }

        public void AddClase(Clase Clase)
        {
            _ContextDb.Clases.Add(Clase);
            _ContextDb.SaveChanges(true);
        }

        public void UpdateClase(Clase Clase)
        {
            _ContextDb.Clases.Update(Clase);
            _ContextDb.SaveChanges(true);
        }

        public void DeleteClase(int IdClase)
        {
            Clase Clase = _ContextDb.Clases.Where(item => item.ClaseId == IdClase).FirstOrDefault();
            _ContextDb.Clases.Remove(Clase);
            _ContextDb.SaveChanges(true);
        }
    }
}
