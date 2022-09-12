using GimnasioFacil.App.Dominio;
using System.Linq;
using System.Collections.Generic; 

namespace GimnasioFacil.App.Persistencia
{
    public class RepositorioRutina : IRepositorioRutina
    {
        
        private readonly AppContext _appContext =new AppContext();

        public Rutina CrearRutina(Rutina rutina)
        {
            var rutinaAdicionado = _appContext.Rutinas.Add(rutina);
            _appContext.SaveChanges();
            return rutinaAdicionado.Entity;
        }
        public Rutina ConsultarRutina(int idRutina)
        {
            return _appContext.Rutinas.FirstOrDefault(p=>p.Id==idRutina);

        }
        public IEnumerable<Rutina> ConsultarRutinas()
        {
            return _appContext.Rutinas;
        }
        public Rutina ActualizarRutina(Rutina rutina)
        {
            var rutinaEncontrado=_appContext.Rutinas.FirstOrDefault(p=>p.Id==rutina.Id);
            
            if(rutinaEncontrado!=null){
                
                rutinaEncontrado.NombreRutina=rutina.NombreRutina;
                rutinaEncontrado.Descripcion=rutina.Descripcion;


                _appContext.SaveChanges();

  
            }
            return rutinaEncontrado;
        }
        public void EliminarRutina (int idRutina)
        {
            var rutinaEncontrado=_appContext.Rutinas.FirstOrDefault(p=>p.Id==idRutina);
            if(rutinaEncontrado==null)
            
            return ;
            _appContext.Rutinas.Remove(rutinaEncontrado);
            _appContext.SaveChanges();
        }
    }   
}       
