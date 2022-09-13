using GimnasioFacil.App.Dominio;
using System.Linq;
using System.Collections.Generic; 

namespace GimnasioFacil.App.Persistencia
{
    public class RepositorioNutricion : IRepositorioNutricion
    {
        private readonly AppContext _appContext =new AppContext();

        public Nutricion CrearNutricion(Nutricion nutricion)
        {
            var nutricionAdicionado = _appContext.Nutriciones.Add(nutricion);
            _appContext.SaveChanges();
            return nutricionAdicionado.Entity;
        }
        public Nutricion ConsultarNutricion(int idNutricion)
        {
            return _appContext.Nutriciones.FirstOrDefault(p=>p.Id==idNutricion);

        }
        public IEnumerable<Nutricion> ConsultarNutriciones()
        {
            return _appContext.Nutriciones;
        }
        public Nutricion ActualizarNutricion(Nutricion nutricion)
        {
            var nutricionEncontrado=_appContext.Nutriciones.FirstOrDefault(p=>p.Id==nutricion.Id);
            
            if(nutricionEncontrado!=null){
                
                nutricionEncontrado.NombreNutricion=nutricion.NombreNutricion;
                nutricionEncontrado.Descripcion=nutricion.Descripcion;


                _appContext.SaveChanges();

  
            }
            return nutricionEncontrado;
        }
        public void EliminarNutricion (int idNutricion)
        {
            var nutricionEncontrado=_appContext.Nutriciones.FirstOrDefault(p=>p.Id==idNutricion);
            if(nutricionEncontrado==null)
            
            return ;
            _appContext.Nutriciones.Remove(nutricionEncontrado);
            _appContext.SaveChanges();
        }
    }   
}     

