﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Conexion
    {
        public readonly String stringConexion = "Data Source=localhost,2000;Initial Catalog=sistemaAAP;User ID=sistemaAAP;Password=sistemaAAP";
        // public SqlConnection conectarbd = new SqlConnection();

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;




        public Conexion()
        {
            try
            {
                cn = new SqlConnection(stringConexion);
                cn.Open();
                //MessageBox.Show("CONECTADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto a la base");

            }
            


        }
        public string query(string consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto no hice la consulta" + ex.ToString());
            }
            return "";
        }
        public string query1(string consulta, string campo)
        {
            try
            {
                cmd = new SqlCommand(consulta, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Console.WriteLine(Convert.ToString(dr[campo]));
                    return Convert.ToString(dr[campo]);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto no hice la consulta" + ex.ToString());
            }
            return "";
        }
        public void ingresardatos(string datos)
        {
            try
            {
                int retorno = 0;
                cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format(datos);
                retorno = cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            

        }
        public void CargarDatos(String consulta, DataGridView tabla)
        {
            try
            {
                DataTable dt2 = new DataTable();
                cn = new SqlConnection(stringConexion);
                cmd = new SqlCommand(consulta, cn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt2);
                tabla.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla");
                MessageBox.Show(Convert.ToString(ex));
            }


        }
        //me retorna una tabla con los valores de solicitados en la consulta

        public DataTable Buscar(string idsolicitante, string consulta)
        {
            DataTable dt2 = new DataTable();

            cn = new SqlConnection(stringConexion);
            cmd = new SqlCommand(consulta, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }


    }
}
