using GimnasioFacil.App.Dominio;
using System.Collections.Generic;

namespace GimnasioFacil.App.Persistencia
{ 
    public interface IRepositorioCliente
    {
        Cliente CrearCliente(Cliente cliente);
        Cliente ConsultarCliente(int idCliente);
        IEnumerable<Cliente> ConsultarClientes();
        Cliente ActualizarCliente(Cliente cliente);
        void EliminarCliente(int idCliente);
        Cliente ConsultarClienteContrasena(string Contrasena);
    }
} 
