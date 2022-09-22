using System.ComponentModel.DataAnnotations;
namespace GimnasioFacil.App.Dominio
{
    public class Rutina
    {
      public int Id {get;set;}
      [Required]
      public string NombreRutina{get;set;}
      [Required]
      public string Descripcion{get;set;}
 
  
      }

} 