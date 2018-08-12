using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVehiculo.Clases
{
    class ListaVehiculos
    {
        List<Vehiculo> vehiculo = new List<Vehiculo>();
        public ListaVehiculos()
        {

        }

        public void Actualizar_Lista()
        {

        } 

        public List<Vehiculo> GetListaVehiculas()
        {
            return vehiculo;
        }
        public int Longitud_Lista()
        {
            return vehiculo.Count();
        }
        
    }
}
