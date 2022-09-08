using System.Collections.Generic;

namespace CursoEFCore.Modelos
{
    public class Clase
    {
        public int ClaseId { get; set; }

        public string Nombre { get; set; }

        public List<Alumno> alumnos { get; set; }
        public int AlumnoId { get; set; }

    }
}
