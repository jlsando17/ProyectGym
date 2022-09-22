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
      [Required]
      public string Email{get;set;} 
      [Required]
      public string Telefono{get;set;}
      [Required]
      public string Direccion{get;set;}
      [Required]
      public string Contrasena{get;set;}
      [Required]
      public string Edad{get;set;}
      [Required]
      public string Peso{get;set;}
      [Required]
      public string Altura{get;set;}
      }

}