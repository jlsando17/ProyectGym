using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GimnasioFacil.App.Presentacion
{
    public class RegistroClientesModel : PageModel
    {
        private string []  ejercicios={"saltar","laso","cuerda"};
        public List<string> listaEjercicios {get;set;}
        public void OnGet()
        {
            listaEjercicios = new List<string>();      
            listaEjercicios.AddRange(ejercicios);
             }
    }
}
