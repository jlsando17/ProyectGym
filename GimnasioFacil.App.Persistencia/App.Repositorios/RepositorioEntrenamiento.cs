using GimnasioFacil.App.Dominio;
using System.Linq;
using System.Collections.Generic; 

namespace GimnasioFacil.App.Persistencia
{
    public class RepositorioEntrenamiento : IRepositorioEntrenamiento
    {
        private readonly AppContext _appContext;
        public RepositorioEntrenamiento(AppContext appContext)
        {
            this._appContext=appContext;
        }
        public Entrenamiento CrearEntrenamiento(Entrenamiento entrenamiento)
        {
            var entrenamientoAdicionado = _appContext.Entrenamientos.Add(entrenamiento);
            _appContext.SaveChanges();
            return entrenamientoAdicionado.Entity;
        }
        public Entrenamiento ConsultarEntrenamiento(int idEntrenamiento)
        {
            return _appContext.Entrenamientos.FirstOrDefault(p=>p.Id==idEntrenamiento);

        }
        public IEnumerable<Entrenamiento> ConsultarEntrenamientos()
        {
            return _appContext.Entrenamientos;
        }
        public Entrenamiento ActualizarEntrenamiento(Entrenamiento entrenamiento)
        {
            var entrenamientoEncontrado=_appContext.Entrenamientos.FirstOrDefault(p=>p.Id==entrenamiento.Id);
            
            if(entrenamientoEncontrado!=null){
                
                entrenamientoEncontrado.Cliente=entrenamiento.Cliente;
                entrenamientoEncontrado.Rutina=entrenamiento.Rutina;
                entrenamientoEncontrado.Nutricion=entrenamiento.Nutricion;
                entrenamientoEncontrado.Fecha=entrenamiento.Fecha; 
                entrenamientoEncontrado.Valoracion=entrenamiento.Valoracion;                


                _appContext.SaveChanges();


            }
            return entrenamientoEncontrado;
        }
        public void EliminarEntrenamiento (int idEntrenamiento)
        {
            var entrenamientoEncontrado=_appContext.Entrenamientos.FirstOrDefault(p=>p.Id==idEntrenamiento);
            if(entrenamientoEncontrado==null)
            
            return ;
            _appContext.Entrenamientos.Remove(entrenamientoEncontrado);
            _appContext.SaveChanges();
        }
    }   
}     

