using GimnasioFacil.App.Dominio;
using System.Collections.Generic;

namespace GimnasioFacil.App.Persistencia
{
    public interface IRepositorioEntrenamiento
    {
        Entrenamiento CrearEntrenamiento(Entrenamiento entrenamiento);
        Entrenamiento ConsultarEntrenamiento(int idEntrenamiento);
        IEnumerable<Entrenamiento> ConsultarEntrenamientos();
        Entrenamiento ActualizarEntrenamiento(Entrenamiento entrenamiento);
        void EliminarEntrenamiento(int idEntrenamiento);
    }
} 