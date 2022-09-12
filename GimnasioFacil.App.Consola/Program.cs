using System;
using GimnasioFacil.App.Dominio;
using GimnasioFacil.App.Persistencia;

namespace GimnasioFacil.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("hello ");
            AdicionarCliente();
        }
        private static void  AdicionarCliente()
        {
            var cliente = new Cliente
            {
                Nombres="luis",
                Apellidos="luis",
                Email="aaa",
                Telefono="222",
                Direccion="1232",
                Contrasena="1232",
                Edad="1231",
                Peso="2312",
                Altura="123"
            };
            _repoCliente.CrearCliente(cliente);

        }
    }

}

     