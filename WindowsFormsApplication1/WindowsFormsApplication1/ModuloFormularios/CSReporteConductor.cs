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
        private string idConductor;
        private string nombreCompletoConductor;
        private string inconvenientesViaje;
        private string descripcionInconveniente;
        private float dineroGastadoEnGasolina;
        private string comportamientoPasajeros;
        private Conexion cnx;
        private SqlConnection conn;

        public CSReporteConductor(string idConductor, string nombreCompletoConductor, string inconvenientesViaje, string descripcionInconveniente, float dineroGastadoEnGasolina, string comportamientoPasajeros)
        {
            this.idConductor = idConductor;
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
        public string getIdConductor()
        {
            return this.idConductor;
        }

        public void setIdConductor(string idConductor)
        {
            this.idConductor = idConductor;

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

                if (inconvenientesViaje.Equals("null"))
                {

                    sql = "insert into ReporteConductor (idchofer, incoveniente,gasto_combustible,comportamiento_pasajeros) values(" + idConductor + ",null," + dineroGastadoEnGasolina + "," + comportamientoPasajeros + ")";
                }
                else
                {
                    sql = "insert into ReporteConductor (idchofer, incoveniente,gasto_combustible,comportamiento_pasajeros) values(" + idConductor + "," + descripcionInconveniente + "," + dineroGastadoEnGasolina + "," + comportamientoPasajeros + ")";
                }

                SqlCommand comando = new SqlCommand(sql, conn);
                int resultado = comando.ExecuteNonQuery();
                // Comprobar resultado y mandar mensaje de confirmacion o de reintento
                MessageBox.Show(resultado + "");
                MessageBox.Show("" + sql);
            }
            catch (Exception er)
            {
                MessageBox.Show("ERROR");
                Console.WriteLine(er.ToString());
            }
        }
    }
}
