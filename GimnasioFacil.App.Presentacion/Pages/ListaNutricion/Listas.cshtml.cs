using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Persistencia;
using GimnasioFacil.App.Dominio;

namespace GimnasioFacil.App.Presentacion
{
    public class ListasModel : PageModel
    {
        private readonly IRepositorioNutricion _repoNutricion;
        public IEnumerable<Nutricion> listaNutricion{get;set;}
        
        public ListasModel(IRepositorioNutricion reponutricion)
        {
            _repoNutricion=reponutricion;
        } 

        public void OnGet()
        {
            listaNutricion=new List<Nutricion>();
            listaNutricion=_repoNutricion.ConsultarNutriciones();
        }
    }
}
