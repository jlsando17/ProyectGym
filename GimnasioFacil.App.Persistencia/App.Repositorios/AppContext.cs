using Microsoft.EntityFrameworkCore;
using GimnasioFacil.App.Dominio;

namespace GimnasioFacil.App.Persistencia
{
  public class AppContext:DbContext
  {
    public DbSet<Cliente> Clientes{get;set;}
    public DbSet<Entrenamiento> Entrenamientos{get;set;}
    public DbSet<Nutricion> Nutriciones{get;set;}
    public DbSet<Rutina> Rutinas{get;set;}
    public DbSet<Valoracion> Valoraciones{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= GimnasioFacilData");
        }
    }
  }

}