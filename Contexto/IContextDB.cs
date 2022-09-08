using CursoEFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CursoEFCore.Contexto
{
    public interface IContextDB
    {

        public DbSet<Colegio> Colegios { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Clase> Clases { get; set; }

        public  DbSet<Alumno> Alumnos { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
