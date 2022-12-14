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
    public class FormularioClienteModel : PageModel
    {
        [BindProperty]
        public Cliente Cli{get;set;}

        private readonly IRepositorioCliente _repoCliente;

        public FormularioClienteModel(IRepositorioCliente repoCliente)
        {
            _repoCliente=repoCliente;
        }


        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoCliente.CrearCliente(Cli);
            return RedirectToPage("/ListaClientes/tablaClientes");
        }
    }
}
