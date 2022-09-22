using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Dominio;
using GimnasioFacil.App.Persistencia;

namespace GimnasioFacil.App.Presentacion.Pages
{
    public class FormularioNModel : PageModel
    { 
        [BindProperty]
        public Nutricion Nuti{get;set;}

        private readonly IRepositorioNutricion _repoNutricion;

        public FormularioNModel(IRepositorioNutricion repoNutricion)
        {
            _repoNutricion=repoNutricion;
        }


        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoNutricion.CrearNutricion(Nuti);
            return RedirectToPage("/ListaNutricion/Listas");
        }
    }
}
