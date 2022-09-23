using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Persistencia;
using GimnasioFacil.App.Dominio;

namespace GimasioFacil.App.Presentacion.Pages
{   
    public class EditarNModel : PageModel
    {
        private readonly IRepositorioNutricion _repoNutricion;
        [BindProperty]
        public Nutricion nuti {get;set;}

        public EditarNModel(IRepositorioNutricion repoNutricion)
        {
            _repoNutricion=repoNutricion;
        }
        public void OnGet(int NutricionId)
        {
          nuti=_repoNutricion.ConsultarNutricion(NutricionId);
        }
        public async Task<IActionResult> OnPost()
        {
            nuti=_repoNutricion.ActualizarNutricion(nuti);
            if(nuti==null)
            {
                return Page();
            }
            return RedirectToPage("/ListaNutricion/Listas");
        }
    }
}
