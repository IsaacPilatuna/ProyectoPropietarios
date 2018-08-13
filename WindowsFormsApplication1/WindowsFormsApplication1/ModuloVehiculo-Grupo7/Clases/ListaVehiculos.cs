using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ModuloVehiculo.Clases
{
    class ListaVehiculos
    {
        List<Vehiculo> vehiculo = new List<Vehiculo>();
        Conexion3 cnn = new Conexion3();
        public ListaVehiculos()
        {
            SqlDataReader dr = cnn.queryLista("select * from VEHICULO");
            while (dr.Read())
            {
                vehiculo.Add(new Vehiculo(Convert.ToString(dr["PLACAVEHICULO"]), Convert.ToString(dr["matricula"]), Convert.ToString(dr["TIPOVEHICULO"]), Convert.ToInt32(dr["numeroPasajeros"]), Convert.ToInt32(dr["anioVehiculo"]), Convert.ToInt32(dr["IDVEHICULO"])));
            }
            dr.Close();
        }

        public void Actualizar_Lista()
        {
            SqlDataReader dr = cnn.queryLista("select * from VEHICULO");
            vehiculo.Clear();
            while (dr.Read())
            {
                vehiculo.Add(new Vehiculo(Convert.ToString(dr["PLACAVEHICULO"]), Convert.ToString(dr["matricula"]), Convert.ToString(dr["TIPOVEHICULO"]), Convert.ToInt32(dr["numumeroPasajeros"]), Convert.ToInt32(dr["anioVehiculo"]), Convert.ToInt32(dr["IDVEHICULO"])));
            }
            dr.Close();
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
