using ModuloFormularios;
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
using WindowsFormsApplication1.ModuloDisponibilidad;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmPrincipalFormularioProfesor : Form
    {
        Usuario usu;
        private Conexion cnx;
        private SqlConnection conn;
        public FrmPrincipalFormularioProfesor()
        {
            InitializeComponent();
            this.cnx = new Conexion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            FrmSolicitudDeViaje solicitudDeViaje = new FrmSolicitudDeViaje();
            solicitudDeViaje.llenarFormulario(usu.Nombre, usu.Email);
            solicitudDeViaje.llenarMotivos();
            solicitudDeViaje.ponerIDs("" + usu.IDusuario1);
            solicitudDeViaje.Show();
        }

        public void ponerUsuario(object usu)
        {
            this.usu = (Usuario)usu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (existeCalificacion())
            {
                FrmCalificacionServicio calificacionServicio = new FrmCalificacionServicio(usu.IDusuario1 + "", idReservaCalificacion());
                calificacionServicio.Show();
            }
            else {
                new FrmMensajeError().Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipalFormularioProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public string[] idReservaCalificacion()
        {
            string sql = "select idReservaAprob from reservaaprobada where idusuario=" + usu.IDusuario1 + " and calificacionservicio is null and estadosolicitud is null ";
            string[] valores = null;
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader reader = comando.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {

                    valores[i] = reader[0] + "";
                    i++;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return valores;
        }

        public bool existeCalificacion()
        {
            string sql = "select count(*) from reservaaprobada where idusuario=" + usu.IDusuario1 + " and calificacionservicio is null and estadosolicitud is null";
            string valor = "";
            MessageBox.Show(sql + "");
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader[0] + "";

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

            if (valor == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuDisponibilidad disponibilidad = new MenuDisponibilidad();
            disponibilidad.Show();
        }
    }
}

