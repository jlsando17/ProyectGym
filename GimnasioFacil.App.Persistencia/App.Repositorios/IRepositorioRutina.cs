using GimnasioFacil.App.Dominio;
using System.Collections.Generic;

namespace GimnasioFacil.App.Persistencia
{
    public interface IRepositorioRutina
    {
        Rutina CrearRutina(Rutina rutina);
        Rutina ConsultarRutina(int idRutina);
        IEnumerable<Rutina> ConsultarRutinas();
        Rutina ActualizarRutina(Rutina rutina);
        void EliminarRutina(int idRutina);
    }
}  