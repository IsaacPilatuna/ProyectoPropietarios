using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ModuloVehiculo.Clases
{
    class Mantenimiento
    {
        private int id_vehiculo { get; set; }
        private int idmatenimiento { get; set; }
        private float kilometraje { get; set; }
        private string estado_aceite { get; set; }
        private float tiempo_uso { get; set; }
        private DateTime fecha_mantenimiento { get; set; }
        Conexion3 cnn = new Conexion3();
        public Mantenimiento(float kilometraje, string estado_aceite, float tiempo_uso, DateTime fecha_mantenimiento)
        {
            this.id_vehiculo = Convert.ToInt32(cnn.query1("select max(IDVEHICULO) as idv from VEHICULO", "idv"));

            System.Console.WriteLine("************************************", id_vehiculo);
            this.kilometraje = kilometraje;
            this.estado_aceite = estado_aceite;
            this.tiempo_uso = tiempo_uso;
            this.fecha_mantenimiento = fecha_mantenimiento;
            this.idmatenimiento = 1+Convert.ToInt32(cnn.query1("select max(idMantenimiento) as idma from Mantenimiento", "idma"));
        }

        public void Verificar_Mantenimiento()
        {

        }
        public void Regitrar_Mantenimiento()
        {
            string format = "yyyy-MM-dd";
            cnn.ingresardatos("insert into Mantenimiento values ("+Convert.ToString(idmatenimiento)+", "+estado_aceite+","+kilometraje+","+id_vehiculo+",'"+fecha_mantenimiento.ToString(format)+"',"+tiempo_uso+")");
        }

    }
}
