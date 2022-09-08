using CursoEFCore.Modelos;
using System;
using System.Collections.Generic;

namespace CursoEFCore.Servicios
{
    public interface IColegioService
    {

        public List<Colegio> GetAllColegio();

        public Colegio GetByIdColegio(int IdAlumno);

        public void AddColegio(Colegio colegio);

        public void UpdateColegio(Colegio colegio);

        public void DeleteColegio(int IdColegio);

    }
}
