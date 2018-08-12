using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Cargo
    {

        SqlDataReader leer;
        private Conexion2 conexion = new Conexion2();

        private int IDcargo;
        private string nombreCargo;

        public int IDcargo1 { get => IDcargo; set => IDcargo = value; }
        public string NombreCargo { get => nombreCargo; set => nombreCargo = value; }

        public SqlDataReader obtenerDatos(String usuario)
        {
            string sql = "Select c.IDcargo,c.nombreCargo from Cargos as c, Usuarios as u  where c.IDcargo = u.IDcargo and u.email = '"+usuario+"'";


            SqlCommand comando = new SqlCommand();
            comando.Connection = (conexion.abrirConexion());
            comando.CommandText = sql;

            leer = comando.ExecuteReader();

            return leer;
        }
    }
}
