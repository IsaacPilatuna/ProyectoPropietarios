using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1


{
    public class Cuenta
    {

        SqlDataReader leer;
        private Conexion2 conexion = new Conexion2();
        private String usuario;
        private String contraseña;



        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }


        public SqlDataReader obtenerDatos()
        {


            string sql = "Select * from Cuenta " +
                "where Cuenta.Contraseña ='" + this.Contraseña + "'and Cuenta.IDUsuario = '" + this.Usuario + "'";

            SqlCommand comando = new SqlCommand();
            comando.Connection = (conexion.abrirConexion());
            comando.CommandText = sql;

            leer = comando.ExecuteReader();

            return leer;

        }

    }
}
