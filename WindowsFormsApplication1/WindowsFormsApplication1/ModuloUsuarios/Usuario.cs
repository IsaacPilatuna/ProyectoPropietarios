using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Usuario
    {

        //private Conexion conexion = new Conexion();
        private Conexion2 conexion = new Conexion2();
        int IDusuario;
        string nombre;
        int IDcargo;
        string departamento;
        string email;

        public int IDusuario1 { get => IDusuario; set => IDusuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IDcargo1 { get => IDcargo; set => IDcargo = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Email { get => email; set => email = value; }


        public SqlDataReader obtenerDatos(String usuario)
        {
            SqlDataReader leer;
            string sql = "Select * from Usuarios  where Usuarios.email = '" + usuario + "'";


            SqlCommand comando = new SqlCommand();
            comando.Connection = (conexion.abrirConexion());
            comando.CommandText = sql;

            leer = comando.ExecuteReader();

            return leer;
            
        }


       
    }
}
