using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    public class ColegioService: IColegioService
    {
        private readonly IContextDB _ContextDb;

        public ColegioService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        public List<Colegio> GetAllColegio()
        {
            return _ContextDb.Colegios.ToList();
        }

        public Colegio GetByIdColegio(int IdColegio)
        {
            return _ContextDb.Colegios.Where(item => item.ColegioId == IdColegio).FirstOrDefault();
        }

        public void AddColegio(Colegio Colegio)
        {
            _ContextDb.Colegios.Add(Colegio);
            _ContextDb.SaveChanges(true);
        }

        public void UpdateColegio(Colegio Colegio)
        {
            _ContextDb.Colegios.Update(Colegio);
            _ContextDb.SaveChanges(true);
        }

        public void DeleteColegio(int IdColegio)
        {
            Colegio Colegio = _ContextDb.Colegios.Where(item => item.ColegioId == IdColegio).FirstOrDefault();
            _ContextDb.Colegios.Remove(Colegio);
            _ContextDb.SaveChanges(true);
        }
    }
}
