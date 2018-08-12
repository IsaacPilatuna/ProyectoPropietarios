using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Reserva reserva;
        Conexion coneccion;


        public Form1()
        {
            InitializeComponent();
            confirmarBtn.Enabled = false;
            coneccion = new Conexion();
            reserva = new Reserva();

            coneccion.Conectar();
            coneccion.CargarDatos2("select*from SolicitudReserva where estadoSolicitud='aprobada1'", dataGridView1);
        }

        

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            reserva.reservar(this.reserva);

            numReservaTxt.Clear();
            numPersonas.Value = 0;
            motivoViajeTxt.Clear();
            tipoUsr.Clear();
            nombreText.Clear();
            fechaIni.Value = DateTime.Today;
            fechaFinaliza.Value = DateTime.Today;
            confirmarBtn.Enabled = false;
            coneccion.CargarDatos2("select*from SolicitudReserva where estadoSolicitud='aprobada1'", dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                coneccion.Conectar();

                reserva.IdReserva= Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                numReservaTxt.Text = reserva.IdReserva.ToString();

                reserva.NumeroPersonas= Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                numPersonas.Value = reserva.NumeroPersonas;

                reserva.IdMotivoViaje= Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                SqlCommand cmdAux2 = new SqlCommand("select descripcion from MotivoViaje WHERE idMotivoViaje=" + reserva.IdMotivoViaje, coneccion.getConnection());
                String motivo= (String)cmdAux2.ExecuteScalar();
                motivoViajeTxt.Text = motivo;
                
                reserva.IdCategoriaUsuario = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                tipoUsr.Text = reserva.IdCategoriaUsuario.ToString();

                reserva.FechaInicio= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                fechaIni.Value = Convert.ToDateTime(reserva.FechaInicio);

                reserva.FechaFin=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                fechaFinaliza.Value = Convert.ToDateTime(reserva.FechaFin);

                reserva.Estado = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                SqlCommand cmdAux1 = new SqlCommand("select nombre from Usuarios WHERE IDusuario=" + reserva.IdCategoriaUsuario, coneccion.getConnection());
                reserva.NombreSolicitante = (String)cmdAux1.ExecuteScalar();
                nombreText.Text = reserva.NombreSolicitante.ToString();

                coneccion.Desconectar();
                confirmarBtn.Enabled = true;
            }

            

        }

        
    }
}
