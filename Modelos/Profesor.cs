using System.Collections.Generic;

namespace CursoEFCore.Modelos
{
    public class Profesor
    {
        public int ProfesorId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public List<Clase> clases { get; set; }
        public int ClaseId { get; set; }
    }
}
