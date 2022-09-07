using GimnasioFacil.App.Dominio;
using System.Collections.Generic;

namespace GimnasioFacil.App.Persistencia
{
    public interface IRepositorioNutricion
    {
        Nutricion CrearNutricion(Nutricion nutricion);
        Nutricion ConsultarNutricion(int idNutricion);
        IEnumerable<Nutricion> ConsultarNutriciones();
        Nutricion ActualizarNutricion(Nutricion nutricion);
        void EliminarNutricion(int idNutricion);
    }
}  