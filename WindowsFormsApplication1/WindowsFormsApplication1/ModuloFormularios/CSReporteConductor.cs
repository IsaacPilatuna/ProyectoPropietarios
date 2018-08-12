using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class CSReporteConductor
    {
        private string idReservaAprobada;
        private string idConductor;
        private string nombreCompletoConductor;
        private string inconvenientesViaje;
        private string descripcionInconveniente;
        private float dineroGastadoEnGasolina;
        private string comportamientoPasajeros;
        private Conexion cnx;
        private SqlConnection conn;

        public CSReporteConductor(string idReservaAprobada, string nombreCompletoConductor, string inconvenientesViaje, string descripcionInconveniente, float dineroGastadoEnGasolina, string comportamientoPasajeros)
        {
            this.idReservaAprobada = idReservaAprobada;
            this.nombreCompletoConductor = nombreCompletoConductor;
            this.inconvenientesViaje = inconvenientesViaje;
            this.descripcionInconveniente = descripcionInconveniente;
            this.dineroGastadoEnGasolina = dineroGastadoEnGasolina;
            this.comportamientoPasajeros = comportamientoPasajeros;
        }
        public CSReporteConductor()
        {
            this.cnx = new Conexion();

        }
        public string getIdReservaAprobada()
        {
            return this.idReservaAprobada;
        }

        public void setIdReservaAprobada(string idReservaAprobada)
        {
            this.idReservaAprobada = idReservaAprobada;

        }
        public string getIdConductor()
        {
            return this.idConductor;
        }

        public void setIdConductor(string idConductor)
        {
            this.idConductor= idConductor;

        }

        public string getNombreCompletoConductor()
        {
            return this.nombreCompletoConductor;
        }

        public void setNombreCompletoConducto(string nombreCompletoConductor)
        {
            this.nombreCompletoConductor = nombreCompletoConductor;

        }

        public string getInconvenientesViaje()
        {
            return this.inconvenientesViaje;
        }


        public void setInconvenientesViaje(string inconvenientesViaje)
        {
            this.inconvenientesViaje = inconvenientesViaje;

        }

        public string getDescripcionInconveniente()
        {
            return this.descripcionInconveniente;
        }


        public void setDescripcionInconveniente(string descripcionInconveniente)
        {
            this.descripcionInconveniente = descripcionInconveniente;

        }

        public string getComportameientoPasajeros()
        {
            return this.comportamientoPasajeros;
        }

        public void setComportamientoPasajeros(string comportamientoPasajeros)
        {
            this.comportamientoPasajeros = comportamientoPasajeros;

        }

        public float getDineroGastadoEnGasolina()
        {
            return this.dineroGastadoEnGasolina;
        }

        public void setDineroGastadoEnGasolina(float dineroGastadoEnGasolina)
        {
            this.dineroGastadoEnGasolina = dineroGastadoEnGasolina;

        }

        public void guardarEnBase()
        {
            
            try
            {
                cnx = new Conexion();
                conn = new SqlConnection(cnx.stringConexion);
                conn.Open();
                String sql = "";


                if (descripcionInconveniente.Equals("null"))
                {
                    sql = "insert into Reporte_Conductor (idReservaAprob, gasto_combustible,comportamiento_pasajeros) values(" + idReservaAprobada + "," + dineroGastadoEnGasolina + "," + comportamientoPasajeros + ")";
                }
                else
                {

                    sql = "insert into Reporte_Conductor(idReservaAprob, INCONVENIENTE, GASTO_COMBUSTIBLE, COMPORTAMIENTO_PASAJEROS) VALUES(" + idReservaAprobada + ", '" + descripcionInconveniente + "'," + dineroGastadoEnGasolina + "," + comportamientoPasajeros + ")";
                }

                SqlCommand comando = new SqlCommand(sql, conn);
                int resultado = comando.ExecuteNonQuery();
                conn = new SqlConnection(cnx.stringConexion);
                conn.Open();
                comando = new SqlCommand("update reservaaprobada set reporteconductor='V' where IDRESERVAAPROB=" + idReservaAprobada, conn);
                resultado = comando.ExecuteNonQuery();

                MessageBox.Show("REPORTE INGRESADO CORRECTAMENTE");

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL INGRESAR EL REPORTE");
                
            }
        }
    }
}
