using CursoEFCore.Modelos;
using System.Collections.Generic;

namespace CursoEFCore.Servicios
{
    public interface IClaseService
    {

        public List<Clase> GetAllClase();

        public Clase GetByIdClase(int IdAlumno);

        public void AddClase(Clase clase);

        public void UpdateClase(Clase clase);

        public void DeleteClase(int IdClase);

    }
}
