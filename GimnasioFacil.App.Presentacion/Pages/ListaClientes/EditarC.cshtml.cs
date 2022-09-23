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
    public class EditarCModel : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        [BindProperty]
        public Cliente Cli {get;set;}

        public EditarCModel(IRepositorioCliente repoCliente)
        {
            _repoCliente=repoCliente;
        }
        public void OnGet(int ClienteId)
        {
          Cli=_repoCliente.ConsultarCliente(ClienteId);
        }
        public async Task<IActionResult> OnPost()
        {
            Cli=_repoCliente.ActualizarCliente(Cli);
            if(Cli==null)
            {
                return Page();
            }
            return RedirectToPage("/ListaClientes/tablaClientes");
        }
    }
}
