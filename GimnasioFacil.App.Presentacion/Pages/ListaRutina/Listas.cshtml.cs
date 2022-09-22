using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Persistencia;
using GimnasioFacil.App.Dominio;

namespace GimnasioFacil.App.Presentacion.Pages
{
    public class ListasModel : PageModel
    {
        private readonly IRepositorioRutina _repoRutina;
        public IEnumerable<Rutina> listaRutina{get;set;}

        public ListasModel(IRepositorioRutina reporutina)
        {
            _repoRutina=reporutina;
        }
        public void OnGet() 
        {
            listaRutina=new List<Rutina>();
            listaRutina=_repoRutina.ConsultarRutinas();

        }

    }
}
