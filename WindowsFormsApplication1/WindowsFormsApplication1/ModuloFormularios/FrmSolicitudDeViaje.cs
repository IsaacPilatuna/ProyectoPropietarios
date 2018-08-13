using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.ModuloFormularios;

namespace ModuloFormularios
{
    public partial class FrmSolicitudDeViaje : Form
    {
        private Conexion cnx = new Conexion();
        private SqlConnection conn;
        private string idusuario;
        private string idmotivo;
        string destino;
        public FrmSolicitudDeViaje()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            conn = new SqlConnection(cnx.stringConexion);
        }

        public void llenarFormulario(String nombre, string email) {
            txt_ciSolicitante.Text = email;
            txt_nombreSolicitante.Text = nombre;
        }

        public void llenarMotivos()
        {
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT idMotivoViaje, descripcion FROM dbo.MotivoViaje", conn);
                SqlDataReader reader = comando.ExecuteReader();
                comboBoxMotivos.DisplayMember = "Text";
                comboBoxMotivos.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxMotivos.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxMotivos.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void ponerIDs(String idusuario) {
            this.idusuario = idusuario;
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                destino = textBox2.Text + "," + comboBox1.SelectedItem.ToString();
                //string idUsuario,string idmotivo, string destino, string fechaSalida, string horaSalida, string fechaRetorno, string horaRetorno, int numeroPersonas
                int idMotivo = comboBoxMotivos.SelectedIndex + 1;
                CSSolicitudDeViaje solicitudDeViaje = new CSSolicitudDeViaje(idusuario, "" + idMotivo, destino, dtf_salida.Text, dth_salida.Text, dtf_llegada.Text, dth_llegada.Text, Convert.ToInt32(textBox1.Text));
                solicitudDeViaje.guardarEnBase();
                this.Close();
            }

        }
    }
}
