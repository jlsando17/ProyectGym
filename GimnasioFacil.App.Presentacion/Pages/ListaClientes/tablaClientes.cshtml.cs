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
    public class tablaClientesModel : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        public IEnumerable<Cliente> listaCliente{get;set;}
        
        public tablaClientesModel(IRepositorioCliente repocliente)
        {
            _repoCliente=repocliente;
        } 

        public void OnGet()
        {
            listaCliente=new List<Cliente>();
            listaCliente=_repoCliente.ConsultarClientes();
        }
    }
}