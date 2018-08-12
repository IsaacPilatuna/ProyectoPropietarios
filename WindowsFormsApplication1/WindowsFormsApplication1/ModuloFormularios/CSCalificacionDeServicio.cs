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
                MessageBox.Show("1");
                conn = new SqlConnection(cnx.stringConexion);
                MessageBox.Show("2");
                conn.Open();
                MessageBox.Show("3");
                String sql = "";

                if (comentariosAdicionales==null)
                {
                    sql = "insert into Calificacion_Servicio (idReservaAprob, puntualSalida, limpieza, puntualDestino, puntualRetorno) values("+idReserva + ",'" + puntualSalida + "','" + limpiezaVehiculo + "','" + puntualAlDestino + "','" + puntualAlRetorno + "')";
                }
                else
                {
                    sql = "insert into Calificacion_Servicio (idReservaAprob, puntualSalida, limpieza, puntualDestino, puntualRetorno, comentarioAdicional) values(" + idReserva + ",'" + puntualSalida + "','" + limpiezaVehiculo + ",'" + puntualAlDestino + "','" + puntualAlRetorno + "','"+ comentariosAdicionales+"')";
                }
                MessageBox.Show("" + sql);
                
                SqlCommand comando = new SqlCommand(sql, conn);
                int resultado = comando.ExecuteNonQuery();
                
                conn = new SqlConnection(cnx.stringConexion);
                conn.Open();
                comando = new SqlCommand("update reservaaprobada set calificacionservicio='V' where IDRESERVAAPROB="+idReserva, conn);
                resultado = comando.ExecuteNonQuery();
                MessageBox.Show("CALIFICACIÓN GENERADA CON ÉXITO");
            }
            catch (Exception er)
            {
                MessageBox.Show("ERROR");
                Console.WriteLine(er.ToString());
            }
        }






    }
}
