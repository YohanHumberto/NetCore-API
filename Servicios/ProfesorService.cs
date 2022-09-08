using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    public class ProfesorService
    {
        private readonly IContextDB _ContextDb;

        public ProfesorService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        public List<Profesor> GetAllProfesores()
        {
            return _ContextDb.Profesores.ToList();
        }

        public Profesor GetByIdProfesores(int IdProfesores)
        {
            return _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
        }

        public void AddProfesores(Profesor Profesores)
        {
            _ContextDb.Profesores.Add(Profesores);
            _ContextDb.SaveChanges(true);
        }

        public void UpdateProfesores(Profesor Profesores)
        {
            _ContextDb.Profesores.Update(Profesores);
            _ContextDb.SaveChanges(true);
        }

        public void DeleteProfesores(int IdProfesores)
        {
            Profesor Profesores = _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
            _ContextDb.Profesores.Remove(Profesores);
            _ContextDb.SaveChanges(true);
        }
    }
}
