using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace CursoEFCore.Servicios
{
    public class ProfesorService: IProfesorService
    {
        private readonly IContextDB _ContextDb;

        public ProfesorService(IContextDB contextDB)
        {
            this._ContextDb = contextDB;
        }

        public List<Profesor> GetAllProfesor()
        {
            return _ContextDb.Profesores.ToList();
        }

        public Profesor GetByIdProfesor(int IdProfesores)
        {
            return _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
        }

        public void AddProfesor(Profesor Profesores)
        {
            _ContextDb.Profesores.Add(Profesores);
            _ContextDb.SaveChanges(true);
        }

        public void UpdateProfesor(Profesor Profesores)
        {
            _ContextDb.Profesores.Update(Profesores);
            _ContextDb.SaveChanges(true);
        }

        public void DeleteProfesor(int IdProfesores)
        {
            Profesor Profesores = _ContextDb.Profesores.Where(item => item.ProfesorId == IdProfesores).FirstOrDefault();
            _ContextDb.Profesores.Remove(Profesores);
            _ContextDb.SaveChanges(true);
        }
    }
}
