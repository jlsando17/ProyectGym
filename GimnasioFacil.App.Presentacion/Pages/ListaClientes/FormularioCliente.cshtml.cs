using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GimnasioFacil.App.Dominio;

namespace GimnasioFacil.App.Presentacion.Pages
{
    public class FormularioClienteModel : PageModel
    {
        [BindProperty]
        public Cliente Cli{get;set;}
        public void OnGet()
        {
        }
    }
}
