using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloRutas.Clases
{
    public class Conexion
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
        public void query(String consulta)
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
        }
        public void CargarDatosIncidencia(DataGridView tabla)
        {
            try
            {
                DataTable dt2 = new DataTable();
                cn = new SqlConnection(stringConexion);
                cmd = new SqlCommand("Select * from incidencia", cn);
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

        public void CargarDatosKilometraje(DataGridView tabla)
        {
            try
            {
                DataTable dt2 = new DataTable();
                cn = new SqlConnection(stringConexion);
                cmd = new SqlCommand("Select * from HISTORIALKILOMETRAJE", cn);
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

        //public void InsertarDatosKilometraje(int id, DateTime fecha,float kilometraje , string placa)
        //{
        //    try
        //    { 
        //        cn = new SqlConnection(stringConexion);
        //        cmd = new SqlCommand("insert into HISTORIALKILOMETRAJE values(id,fecha,kilometraje,placa)", cn);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("no se pudo insertar datos de kilometraje");
        //        MessageBox.Show(Convert.ToString(ex));
        //    }


        //}
        //me retorna una tabla con los valores de solicitados en la consulta

        public DataTable Buscar(/*string idsolicitante,*/ string consulta)
        {
            DataTable dt2 = new DataTable();

            cn = new SqlConnection(stringConexion);
            cmd = new SqlCommand(consulta, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }
        public void llenarItems(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select PLACAVEHICULO from VEHICULO", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["PLACAVEHICULO"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox", ex.ToString());
            }
        }

        public void llenarItemsID(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select idVEHICULO from VEHICULO", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["idVEHICULO"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox", ex.ToString());
            }
        }
        public void llenarData(TextBox tb)
        {
            string lugar = "";
            string[] substrings = { };

            try
            {
                cmd = new SqlCommand("SELECT lugar FROM SolicitudReserva WHERE idSolicitudReserva = (SELECT MAX(idSolicitudReserva) from SolicitudReserva)", cn);
                Object dr2 = cmd.ExecuteScalar();
                lugar = dr2.ToString();
                substrings = lugar.Split(',');
                tb.Text = substrings[0];
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el text box", ex.ToString());
            }
        }

    }
}

