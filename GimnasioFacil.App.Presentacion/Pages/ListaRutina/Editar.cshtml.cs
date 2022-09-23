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
    public class EditarModel : PageModel
    {
        private readonly IRepositorioRutina _repoRutina;
        [BindProperty]
        public Rutina ruti {get;set;}

        public EditarModel(IRepositorioRutina repoRutina)
        {
            _repoRutina=repoRutina;
        }
        public void OnGet(int RutinaId)
        {
          ruti=_repoRutina.ConsultarRutina(RutinaId);
        }
        public async Task<IActionResult> OnPost()
        {
            ruti=_repoRutina.ActualizarRutina(ruti);
            if(ruti==null)
            {
                return Page();
            }
            return RedirectToPage("/ListaRutina/Listas");
        }
    }
}
