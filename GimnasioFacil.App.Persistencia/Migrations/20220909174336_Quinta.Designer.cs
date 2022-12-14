// <auto-generated />
using System;
using GimnasioFacil.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GimnasioFacil.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220909174336_Quinta")]
    partial class Quinta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GimnasioFacil.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Altura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GimnasioFacil.App.Dominio.Entrenamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NutricionId")
                        .HasColumnType("int");

                    b.Property<int?>("RutinaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("NutricionId");

                    b.HasIndex("RutinaId");

                    b.ToTable("Entrenamientos");
                });

            modelBuilder.Entity("GimnasioFacil.App.Dominio.Nutricion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreNutricion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nutriciones");
                });

            modelBuilder.Entity("GimnasioFacil.App.Dominio.Rutina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreRutina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rutinas");
                });

            modelBuilder.Entity("GimnasioFacil.App.Dominio.Entrenamiento", b =>
                {
                    b.HasOne("GimnasioFacil.App.Dominio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("GimnasioFacil.App.Dominio.Nutricion", "Nutricion")
                        .WithMany()
                        .HasForeignKey("NutricionId");

                    b.HasOne("GimnasioFacil.App.Dominio.Rutina", "Rutina")
                        .WithMany()
                        .HasForeignKey("RutinaId");

                    b.Navigation("Cliente");

                    b.Navigation("Nutricion");

                    b.Navigation("Rutina");
                });
#pragma warning restore 612, 618
        }
    }
}
