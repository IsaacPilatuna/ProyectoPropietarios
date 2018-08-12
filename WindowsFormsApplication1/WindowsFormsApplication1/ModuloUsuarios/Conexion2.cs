using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1

{
    public class Conexion2
    {
        //private SqlConnection conn = new SqlConnection("Data Source=localhost,2000; Initial Catalog=sistemaAAP;User ID=grupo3;Password=grupo3Vero");

        private SqlConnection conn = new SqlConnection("Data Source=localhost,2000;Initial Catalog=sistemaAAP;User ID=sistemaAAP;Password=sistemaAAP");
        //private SqlConnection conn = new SqlConnection("Data Source=172.31.101.33,1433;Initial Catalog=SistemaAAP;Persist Security Info=True;User ID=grupoAli;Password=grupoAli");
        public SqlConnection abrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }
        public SqlConnection cerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }
    }
}
