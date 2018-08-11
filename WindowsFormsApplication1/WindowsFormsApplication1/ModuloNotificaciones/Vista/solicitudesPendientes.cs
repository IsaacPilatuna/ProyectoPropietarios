using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class solicitudesPendientes : Form
    {
        string auxemail;
        public solicitudesPendientes(string email)
        {
            auxemail = email;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = dataGridView1.CurrentCell.Value.ToString();
            MessageBox.Show(x);
            Conexion cn = new Conexion();
         

            DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where email= '" + auxemail + "'");
            DataRow row = dtaux.Rows[0];
         
            int idusuario = Convert.ToInt32(row["idusuario"]);
            string facultad = Convert.ToString(row["departamento"]);
            try
            {
                cn.query("update solicitudreserva set estadosolicitud='aprobada1' where idsolicitudreserva='" + x + "'");
            }
            catch
            {
                MessageBox.Show("CAMPO SELECCIANO NO ESTA CORRECTO");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
           
            DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where email= '" + auxemail + "'");
           DataRow row = dtaux.Rows[0];
           string x;
           int idusuario = Convert.ToInt32(row["idusuario"]);
           string facultad = Convert.ToString(row["departamento"]);
            MessageBox.Show(facultad);
          
          // MessageBox.Show("  select *from SolicitudReserva where idSolicitante in (select idSolicitante from Solicitante where facultad ='" + facultad + "'");
           cn.CargarDatos("   select nombre AS NOMBRE_SOLICITANTE, fechasalida AS FECHA_SALIDA, fecharetorno AS FECHA_RETORNO, descripcion AS MOTIVO from Usuarios, MotivoViaje, solicitudreserva where Usuarios.idusuario = solicitudreserva.idusuario AND motivoviaje.idMotivoViaje = solicitudreserva.idMotivoViaje AND departamento ='"+facultad+"'", dataGridView1);
           // MessageBox.Show("    select nombre AS NOMBRE_SOLICITANTE, fechasalida AS FECHA_SALIDA, fecharetorno AS FECHA_RETORNO, descripcion AS MOTIVO from Usuarios, MotivoViaje, solicitudreserva where Usuarios.idusuario = solicitudreserva.idusuario AND motivoviaje.idMotivoViaje = solicitudreserva.idMotivoViaje AND departamento = ' " + facultad + "'");
         // cn.CargarDatos("select * from usuarios", dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


