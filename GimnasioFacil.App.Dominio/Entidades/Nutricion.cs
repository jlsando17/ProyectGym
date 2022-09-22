using System.ComponentModel.DataAnnotations;
namespace GimnasioFacil.App.Dominio
{
    public class Nutricion
    {
    
      public int Id {get;set;}
      [Required]
      public string NombreNutricion{get;set;}
      [Required]
      public string Descripcion{get;set;}

       
      }

} 