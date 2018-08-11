using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class CSCalificacionDeServicio
    {

        private string idReserva;
        private string puntualSalida;
        private string limpiezaVehiculo;
        private string puntualAlDestino;
        private string puntualAlRetorno;
        private string comentariosAdicionales;
        private Conexion cnx;
        private SqlConnection conn;
        

        public CSCalificacionDeServicio(string idReserva,string puntualSalida, string limpiezaVehiculo, string puntualAlDestino, string puntualAlRetorno, string comentariosAdicionales)
        {
            this.idReserva = idReserva;
            this.puntualSalida = puntualSalida;
            this.limpiezaVehiculo = limpiezaVehiculo;
            this.puntualAlDestino = puntualAlDestino;
            this.puntualAlRetorno = puntualAlRetorno;
            this.comentariosAdicionales = comentariosAdicionales;
        }
        public CSCalificacionDeServicio() {
            cnx = new Conexion();
                    }

        public string getIdReserva()
        {
            return this.idReserva;
        }

        public void setIdReserva(string idReserva)
        {
            this.idReserva=idReserva;

        }


        public string getPuntualSalida()
        {
            return this.puntualSalida;
        }

        public void setPuntualSalida(string puntualSalida)
        {
            this.puntualSalida = puntualSalida;

        }

        public string getLimpiezaVehiculo()
        {
            return this.limpiezaVehiculo;
        }

        public void setLimpiezaVehiculo(string limpiezaVehiculo)
        {
            this.limpiezaVehiculo = limpiezaVehiculo;

        }

        public string getPuntualAlDestino()
        {
            return this.puntualAlDestino;
        }

        public void setPuntualAlDestino(string puntualAlDestino)
        {
            this.puntualAlDestino = puntualAlDestino;

        }

        public string getPuntualAlRetorno()
        {
            return this.puntualAlRetorno;
        }

        public void setPuntualAlRetorno(string puntualAlRetorno)
        {
            this.puntualAlRetorno = puntualAlRetorno;

        }

        public string getComentariosAdicionales()
        {
            return this.comentariosAdicionales;
        }

        public void setComentariosAdicionales(string comentariosAdicionales)
        {
            this.comentariosAdicionales = comentariosAdicionales;

        }

        public void guardarEnBase()
        {
            try
            {
                cnx = new Conexion();
                conn = new SqlConnection(cnx.stringConexion);
                conn.Open();
                String sql = "";

                if (comentariosAdicionales==null)
                {
                    //idReserva debe ser verificado (hace relacion a la tabla de solicitud servicio)
                    sql = "insert into CalificiacionDeServicio (idReserva, puntualSalida, limpiezaVehiculo, puntualAlDestino, puntualAlRetorno) values("+idReserva + "," + puntualSalida + "," + limpiezaVehiculo + "," + puntualAlDestino + "," + puntualAlRetorno + ")";
                }
                else
                {
                    sql = "insert into CalificiacionDeServicio (idReserva, puntualSalida, limpiezaVehiculo, puntualAlDestino, puntualAlRetorno, ComentarioAdicional) values(" + idReserva + "," + puntualSalida + "," + limpiezaVehiculo + "," + puntualAlDestino + "," + puntualAlRetorno + ","+ comentariosAdicionales+")";
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
