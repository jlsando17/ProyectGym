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
    public class BuscarCliModel : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        [BindProperty]
        public Cliente cliente {get;set;}

        public BuscarCliModel(IRepositorioCliente repoCliente)
        {
            _repoCliente=repoCliente;
        }
        public string contrasena{get;set;}


        public void OnGet()
        {
            cliente=new Cliente();
        }
        public async Task<IActionResult> OnPost()
        {
          cliente=_repoCliente.ConsultarClienteContrasena(cliente.Contrasena);
          if(cliente==null)
          {
            return RedirectToPage("/Error");
        }
        return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            _repoCliente.ActualizarCliente(cliente);
            if(cliente!=null)
            {
                return RedirectToPage("/ListaClientes/tablaClientes");
            }
            return RedirectToPage("/Error");
        }
    }
}
