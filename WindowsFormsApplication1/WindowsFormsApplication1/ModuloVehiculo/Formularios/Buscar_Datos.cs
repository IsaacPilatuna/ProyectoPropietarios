using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    public partial class Buscar_Datos : Form
    {
        
        public Buscar_Datos()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("select PLACAVEHICULO from VEHICULO", conn);
                reader = comando.ExecuteReader();
              
                while (reader.Read())
                {
                    pLACAVEHICULOComboBox.Items.Add(reader["PLACAVEHICULO"].ToString());

                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Buscar_Datos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.VEHICULO' Puede moverla o quitarla según sea necesario.
            this.vEHICULOTableAdapter.Fill(this.dataSetVehiculo.VEHICULO);

        }

        private void iDVEHICULOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion cn = new Conexion();
                //lleno el combobox con las placas y obtengo la seleccion
                String matricula = pLACAVEHICULOComboBox.SelectedItem.ToString();
                SqlDataReader reader = null;
                MessageBox.Show("La matricula selecionada es: " + matricula);
                // hago la consulta para tener el KM

                DataTable dtaux = cn.Buscar("", "select SUM(kilometraje)*2 as 'kilometrajetotal' from HistorialKilometraje H JOIN VEHICULO V ON H.IDVEHICULO= V.IDVEHICULO where  V.matricula =  '" +matricula+ "' GROUP BY anioVehiculo ;");
                //Imprimo los datos de select
                //foreach (DataRow dataRow in dtaux.Rows)
                //{
                //    foreach (var item in dataRow.ItemArray)
                //    {
                //        Console.WriteLine(item);

                //    }
                //}

                DataRow row = dtaux.Rows[0];
                row = dtaux.Rows[0];
                int kilometraje = Convert.ToInt32(row["KilometrajeTotal"]);
                MessageBox.Show("El kilometraje actual del vehiculo es: " + kilometraje.ToString() );

                if (kilometraje > 100000)
                {
                    MessageBox.Show("El vehiculo con placas: " + matricula + " necesita ir a MANTENIMIENTO ");
                    DataTable dtaux3 = cn.Buscar("", "select IDVEHICULO  from VEHICULO  where matricula = '" + matricula + "';");
                    DataRow row3 = dtaux3.Rows[0];
                    row3 = dtaux3.Rows[0];
                    int idVehiculo = Convert.ToInt32(row3["IDVEHICULO"]);
                    //MessageBox.Show("IDVEHICULO" + idVehiculo.ToString());
                    cn.Buscar("", "UPDATE DisponibilidadVehiculo SET estado_vehiculo = ' NO DISPONIBLE'  where IDVEHICULO = " + idVehiculo + ";");




                }
                else
                {
                    MessageBox.Show("El vehiculo con placas: " + matricula + " puede continuar TRABAJANDO ");
                    DataTable dtaux2 = cn.Buscar("", "select IDVEHICULO  from VEHICULO  where matricula = '" + matricula + "';");
                    DataRow row2 = dtaux2.Rows[0];
                    row2 = dtaux2.Rows[0];
                    int idVehiculo = Convert.ToInt32(row2["IDVEHICULO"]);
                    //MessageBox.Show("IDVEHICULO" + idVehiculo.ToString());
                    cn.Buscar("", "UPDATE DisponibilidadVehiculo SET estado_vehiculo = 'DISPONIBLE'  where IDVEHICULO = " + idVehiculo +";");

                }

                DataTable dtaux1 = cn.Buscar("", "SELECT ((Select year(getdate()))-anioVehiculo) AS TotalAños from VEHICULO  where matricula = '" +matricula+"';");
                DataRow row1 = dtaux1.Rows[0];
                row1 = dtaux1.Rows[0];
                int anioVehiculo = Convert.ToInt32(row1["TotalAños"]);
                MessageBox.Show("El vehiculo tiene : " + anioVehiculo.ToString() + " años de uso");

                if (anioVehiculo > 5)
                {
                    MessageBox.Show("El vehiculo con placas: " + matricula + " debe ser REEMPLAZADO");
                }
                else
                {
                    MessageBox.Show(" El vehiculo con placas: " +matricula+ " puede continuar brindando servicio en la EPN" );
                } 


            }
            catch (Exception)
            {
                MessageBox.Show(" Este vehiculo  no tiene REGISTROS  ");
            }

            //sofig.0106@gmail.com

            /*String matricula =pLACAVEHICULOComboBox.SelectedItem.ToString();
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("select SUM(H.kilometraje)*2 as 'KilometrajeTotal' , D.estado_vehiculo as 'AñoVehiculo'  from VEHICULO V join HistorialKilometraje H on (V.IDVEHICULO = H.idVehiculo) join DisponibilidadVehiculo D on (V.IDVEHICULO = D.IDVEHICULO) where V.placavehiculo ='"+matricula+"' group by D.estado_vehiculo ;", conn);
                reader = comando.ExecuteReader();
                MessageBox.Show("1La matricula es: " + matricula);
                while (reader.Read())
                {

                    //pLACAVEHICULOComboBox.Items.Add(reader["PLACAVEHICULO"].ToString());
                    int kilometraje = int.Parse(reader["KilometrajeTotal"].ToString()) ;
                    int anioVehiculo = int.Parse(reader["AñoVehiculo"].ToString());
                    MessageBox.Show("2La matricula es: " + matricula);
                    if (kilometraje>10000)
                    {
                        MessageBox.Show("El kilometraje esta mucho mande a que le bajen");
                    }
                    if (anioVehiculo > 5)
                    {
                        MessageBox.Show("ya esta viejo comprese otro");
                    }

                }
                reader.Close();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.ToString());
            }
            */


        }
        private void pLACAVEHICULOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String matricula = pLACAVEHICULOComboBox.SelectedItem.ToString();
            //SqlDataReader reader = null;
            //SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            //try
            //{
            //    conn.Open();
            //    SqlCommand comando = new SqlCommand("select SUM(H.kilometraje)*2 as 'KilometrajeTotal' , D.estado_vehiculo as 'AñoVehiculo'  from VEHICULO V join HistorialKilometraje H on (V.IDVEHICULO = H.idVehiculo) join DisponibilidadVehiculo D on (V.IDVEHICULO = D.IDVEHICULO) where V.placavehiculo ='" + matricula + "' group by D.estado_vehiculo ;", conn);
            //    reader = comando.ExecuteReader();
            //    MessageBox.Show("1La matricula es: " + matricula);
            //    //while (reader.Read())
            //    //{
            //    //pLACAVEHICULOComboBox.Items.Add(reader["PLACAVEHICULO"].ToString());
            //    int kilometraje = int.Parse(reader["KilometrajeTotal"].ToString());
            //    int anioVehiculo = int.Parse(reader["AñoVehiculo"].ToString());
            //    MessageBox.Show("2La matricula es: " + matricula);
            //    if (kilometraje > 10000)
            //    {
            //        MessageBox.Show("El kilometraje esta mucho mande a que le bajen");
            //    }
            //    if (anioVehiculo > 5)
            //    {
            //        MessageBox.Show("ya esta viejo comprese otro");
            //    }

            //    //}
            //    reader.Close();
            //}
            //catch (Exception exe)
            //{
            //    Console.WriteLine(exe.ToString());
            //}

        }

        private void pLACAVEHICULOLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
