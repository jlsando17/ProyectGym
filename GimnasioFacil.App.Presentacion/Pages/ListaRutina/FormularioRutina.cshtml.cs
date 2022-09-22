using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Dominio;
using GimnasioFacil.App.Persistencia;

namespace GimnasioFacilo.App.Presetnacion.Pages
{
    public class FormularioRutinaModel : PageModel
    { 
        [BindProperty]
        public Rutina Ruti{get;set;}

        private readonly IRepositorioRutina _repoRutina;

        public FormularioRutinaModel(IRepositorioRutina repoRutina)
        {
            _repoRutina=repoRutina;
        }


        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoRutina.CrearRutina(Ruti);
            return RedirectToPage("/ListaRutina/Listas");
        }
    }
}
