using System.ComponentModel.DataAnnotations;

namespace GimnasioFacil.App.Dominio
{
    public class Cliente
    {
     
      public int Id {get;set;}
      [Required]
      public string Nombres{ get; set; }
      [Required]
      public string Apellidos{ get; set; }
      
      public string Email{get;set;} 
      
      public string Telefono{get;set;}
      
      public string Direccion{get;set;}
      
      public string Contrasena{get;set;}
      
      public string Edad{get;set;}
      
      public string Peso{get;set;}
      
      public string Altura{get;set;}
      }

}