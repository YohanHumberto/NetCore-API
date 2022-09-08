﻿// <auto-generated />
using System;
using CursoEFCore.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CursoEFCore.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20220908192015_MigracionInicia")]
    partial class MigracionInicia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CursoEFCore.Modelos.Alumno", b =>
                {
                    b.Property<int>("AlumnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ClaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("AlumnoId");

                    b.HasIndex("ClaseId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Clase", b =>
                {
                    b.Property<int>("ClaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlumnoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClaseId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Colegio", b =>
                {
                    b.Property<int>("ColegioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ColegioId");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Profesor", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ColegioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfesorId");

                    b.HasIndex("ColegioId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Alumno", b =>
                {
                    b.HasOne("CursoEFCore.Modelos.Clase", null)
                        .WithMany("alumnos")
                        .HasForeignKey("ClaseId");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Clase", b =>
                {
                    b.HasOne("CursoEFCore.Modelos.Profesor", null)
                        .WithMany("clases")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Profesor", b =>
                {
                    b.HasOne("CursoEFCore.Modelos.Colegio", null)
                        .WithMany("profesores")
                        .HasForeignKey("ColegioId");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Clase", b =>
                {
                    b.Navigation("alumnos");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Colegio", b =>
                {
                    b.Navigation("profesores");
                });

            modelBuilder.Entity("CursoEFCore.Modelos.Profesor", b =>
                {
                    b.Navigation("clases");
                });
#pragma warning restore 612, 618
        }
    }
}
