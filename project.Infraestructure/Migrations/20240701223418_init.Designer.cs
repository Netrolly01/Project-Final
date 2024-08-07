﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolActivityApp.Infrastructure.Context;

namespace SchoolActivityApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240701223418_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.Course", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Capacidad")
                    .HasColumnType("int");

                b.Property<int>("CursoID")
                    .HasColumnType("int");

                b.Property<string>("NombreCursoAula")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Courses");
            });

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.Enrollment", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("EstudiantesId")
                    .HasColumnType("int");

                b.Property<DateTime>("FechaInscripcion")
                    .HasColumnType("datetime2");

                b.Property<int>("InscripcionesId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Enrollments");
            });

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.ExtraActivity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("ActividadID")
                    .HasColumnType("int");

                b.Property<int>("CursoID")
                    .HasColumnType("int");

                b.Property<string>("Descripcion")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("FechaFin")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("FechaInicio")
                    .HasColumnType("datetime2");

                b.Property<int>("InstructorID")
                    .HasColumnType("int");

                b.Property<string>("NombreActividad")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("ExtraActivities");
            });

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.Instructor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Apellido")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Especializacion")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Telefono")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Instructors");
            });

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.Schedule", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("DiaSemana")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("HoraInicio")
                    .HasColumnType("int");

                b.Property<int>("Horafin")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Schedules");
            });

            modelBuilder.Entity("SchoolActivityApp.Domain.Entities.Student", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Apellido")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Direccion")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Grado")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Telefono")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Students");
            });
#pragma warning restore 612, 618
        }
    }
}
