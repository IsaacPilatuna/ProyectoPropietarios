using System;
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
        public readonly String stringConexion = "Data Source=localhost,2000;Initial Catalog=sistemaAAP;User ID=sistemaAAP;Password=sistemaAAP;MultipleActiveResultSets=true";
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
            }catch(Exception ex){
                MessageBox.Show("no se conecto a la base");

            }
        }
        public void query(String consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta,cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se conecto no hice la consulta");
            }
        }
        public void CargarDatos( String consulta, DataGridView tabla)
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
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla");
                MessageBox.Show(Convert.ToString(ex));
            }


        }

        public void CargarDatos2(String consulta, DataGridView tabla)
        {
            try
            {
                
                var dataAdapter = new SqlDataAdapter(consulta, this.getConnection());
                var ds = new DataTable();
                dataAdapter.Fill(ds);
                BindingSource bsSource = new BindingSource();
                bsSource.DataSource = ds;
                tabla.ReadOnly = true;
                tabla.DataSource = bsSource;
                this.Desconectar();

                tabla.Columns[0].Visible = false;
                tabla.Columns[1].Visible = false;
                tabla.Columns[2].Visible = false;
                tabla.Columns[7].Visible = false;
                tabla.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla");
                MessageBox.Show(Convert.ToString(ex));
            }


        }
        //me retorna una tabla con los valores de solicitados en la consulta

        public  DataTable Buscar(string idsolicitante, string consulta)
        {
            DataTable dt2 = new DataTable();
            
            cn = new SqlConnection(stringConexion);
            cmd = new SqlCommand(consulta,cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }

        

        public void Conectar()
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

        public SqlConnection getConnection()
        {
            return cn;
        }

        public void Desconectar()
        {
            cn.Close();
        }
    }
}
