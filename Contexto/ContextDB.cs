using CursoEFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoEFCore.Contexto
{
    public class ContextDB : DbContext, IContextDB
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
          
        }
       
        public DbSet<Colegio> Colegios { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Clase> Clases { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colegio>().ToTable("Colegios");
            modelBuilder.Entity<Profesor>().ToTable("Profesores");
            modelBuilder.Entity<Clase>().ToTable("Clases");
            modelBuilder.Entity<Alumno>().ToTable("Alumnos");
        }


    }
}
