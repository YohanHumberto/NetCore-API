using System.Collections.Generic;

namespace CursoEFCore.Modelos
{
    public class Colegio
    {

        public int ColegioId { get; set; }

        public string Nombre { get; set; }

        public List<Profesor> profesores { get; set; }
        public int ProfesorId { get; set; }

    }
}
