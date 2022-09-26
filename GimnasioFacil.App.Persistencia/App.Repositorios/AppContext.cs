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


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source=SQL8002.site4now.net;Initial Catalog=db_a8d601_gimansiofacil;User Id=db_a8d601_gimansiofacil_admin;Password=YOUR_DB_PASSWORD");
        }
    }
  }

}