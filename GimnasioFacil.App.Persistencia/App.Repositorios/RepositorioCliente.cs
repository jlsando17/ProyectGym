using GimnasioFacil.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GimnasioFacil.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AppContext _appContext =new AppContext();


        public Cliente CrearCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        public Cliente ConsultarCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(p=>p.Id==idCliente);

        }
        public IEnumerable<Cliente> ConsultarClientes()
        {
            return _appContext.Clientes;  
        }
        public Cliente ActualizarCliente(Cliente cliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(p=>p.Id==cliente.Id);
            if(clienteEncontrado!=null)
              {          
                clienteEncontrado.Nombres=cliente.Nombres;
                clienteEncontrado.Apellidos=cliente.Apellidos;
                clienteEncontrado.Email=cliente.Email;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Contrasena=cliente.Contrasena;
                clienteEncontrado.Edad=cliente.Edad;
                clienteEncontrado.Peso=cliente.Peso;
                clienteEncontrado.Altura=cliente.Altura;

                _appContext.SaveChanges();


            }
            return clienteEncontrado;
        }
        public void EliminarCliente (int idCliente)
        {
            var clienteEncontrado=_appContext.Clientes.FirstOrDefault(p=>p.Id==idCliente);
            if(clienteEncontrado==null)
            
            return ;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
    }   

}