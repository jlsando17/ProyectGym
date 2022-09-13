using System;
using System.Collections.Generic;

namespace GimnasioFacil.App.Dominio

{
    public class Entrenamiento
    {
     public int Id {get;set;}
     public Cliente Cliente { get; set;} 
      public Rutina Rutina {get;set;}
      public Nutricion Nutricion{get;set;}
     public DateTime Fecha {get; set;} 


      
      }

}