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
        Autorizacion autorizacion = new Autorizacion();
        public solicitudesPendientes(string email)
        {
            auxemail = email;
            InitializeComponent();
            tabPage1.Text = @"Vista pendientes";
            tabPage2.Text = @"Vista rechazadas";
            tabPage3.Text = @"Vista aprobadas";
            cargarDatosSolicitudes(0, dataGridView1); //por defecto apenas se abra la ventana, se cargaran las que estan en espera
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
             String x = dataGridView1.CurrentCell.Value.ToString();
             //MessageBox.Show(x);
            // DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where nombre= '" + x + "'");
            // DataRow row = dtaux.Rows[0];
            // String idusuario = Convert.ToString(row["idusuario"]);
            //MessageBox.Show("id usuarios"+idusuario);
             //DataTable dtaux2 = cn.Buscar(auxemail, "select idsolicitudreserva from solicitudreserva where idusuario='" + x + "'");
             //DataRow row2 = dtaux2.Rows[0];
            // String idreserva = Convert.ToString(row2["idsolicitudreserva"]);
             autorizacion.autorizar(x);
          
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Conexion cn = new Conexion();
            String x = dataGridView1.CurrentCell.Value.ToString();
           // MessageBox.Show(x);
            //DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where nombre= '" + x + "'");
            //DataRow row = dtaux.Rows[0];
            //String idusuario = Convert.ToString(row["idusuario"]);
            //DataTable dtaux2 = cn.Buscar(auxemail, "select idsolicitudreserva from solicitudreserva where idusuario='" + idusuario + "'");
            //DataRow row2 = dtaux2.Rows[0];
            //String idreserva = Convert.ToString(row2["idsolicitudreserva"]);
            autorizacion.rechazar(x);

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
          //tab page seleccionada
            if (tabControl1.SelectedIndex == 0)
            {
                cargarDatosSolicitudes(0, dataGridView1);//en espera
               
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cargarDatosSolicitudes(1, dataGridView2);//rechazadas
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                cargarDatosSolicitudes(2, dataGridView3);//aprobadas
            }


        }


        //para cargar datos en las datagriewview, int bandera=0 -> en espera, int bandera=1 ->rechazadas

        private void cargarDatosSolicitudes(int bandera, DataGridView dgv)
        {
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where email= '" + auxemail + "'");
            DataRow row = dtaux.Rows[0];
            string x;
            int idusuario = Convert.ToInt32(row["idusuario"]);
            string facultad = Convert.ToString(row["departamento"]);
           
         
            if (bandera==0)
            {
                cn.CargarDatos("select idsolicitudreserva AS N_SOLICITUD, nombre AS NOMBRE_SOLICITANTE, fechasalida AS FECHA_SALIDA, fecharetorno AS FECHA_RETORNO,lugar AS LUGAR, descripcion AS MOTIVO from Usuarios, MotivoViaje, solicitudreserva where Usuarios.idusuario = solicitudreserva.idusuario AND motivoviaje.idMotivoViaje = solicitudreserva.idMotivoViaje AND estadosolicitud='en espera' AND departamento ='" + facultad + "'", dgv);

            }
            else if (bandera == 1)
            {
                cn.CargarDatos("select idsolicitudreserva AS N_SOLICITUD, nombre AS NOMBRE_SOLICITANTE, fechasalida AS FECHA_SALIDA, fecharetorno AS FECHA_RETORNO,lugar AS LUGAR, descripcion AS MOTIVO from Usuarios, MotivoViaje, solicitudreserva where Usuarios.idusuario = solicitudreserva.idusuario AND motivoviaje.idMotivoViaje = solicitudreserva.idMotivoViaje AND estadosolicitud='rechazada' AND departamento ='" + facultad + "'", dgv);
            }
            else if (bandera == 2)
            {
                cn.CargarDatos("select idsolicitudreserva AS N_SOLICITUD, nombre AS NOMBRE_SOLICITANTE, fechasalida AS FECHA_SALIDA, fecharetorno AS FECHA_RETORNO,lugar AS LUGAR, descripcion AS MOTIVO from Usuarios, MotivoViaje, solicitudreserva where Usuarios.idusuario = solicitudreserva.idusuario AND motivoviaje.idMotivoViaje = solicitudreserva.idMotivoViaje AND estadosolicitud='aprobada1' AND departamento ='" + facultad + "'", dgv);
            }
        }

     }
}


