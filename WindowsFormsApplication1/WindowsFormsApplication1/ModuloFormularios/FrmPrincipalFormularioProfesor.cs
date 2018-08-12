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

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmPrincipalFormularioProfesor : Form
    {
        Usuario usu;
        private Conexion cnx;
        private SqlConnection conn;
        private string valor;
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
                FrmCalificacionServicio calificacionServicio = new FrmCalificacionServicio(usu.IDusuario1 + "",usu.Nombre ,idReservaCalificacion());
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
            Conexion cn = new Conexion();
            string[] valores = new string[Convert.ToInt32(valor)];
            
            DataTable dtaux = cn.Buscar("", "select IDRESERVAAPROB from reservaaprobada where IDSOLICITANTE =" + usu.IDusuario1 + " and calificacionservicio is null and estadosolicitud like 'aprobadA2'");
            for (Int32 j=0; j < Convert.ToInt32(valor); j++)
            {
                DataRow row = dtaux.Rows[j];
                valores[j] = Convert.ToString(row["IDRESERVAAPROB"]);
            }
          
            return valores;
        }

        public bool existeCalificacion()
        {
            string sql = "select count(*) from reservaaprobada where IDSOLICITANTE="+ usu.IDusuario1+" and calificacionservicio is null and estadosolicitud like 'aprobada2'";
            valor = "";
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
       
    }
}

