using ModuloVehiculo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace ModuloVehiculo.Interfaz
{
    public partial class VehiculosDelte : Form
    {
        private string valor;
        public VehiculosDelte()
        {
            InitializeComponent();
        }

        private void VehiculosDelte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                valor = dataGridView1["IDVEHICULO", e.RowIndex].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                Conexion3 cnn = new Conexion3();
                cnn.query("delete from incidenciaVehiculo where IDVEHICULO=" + valor);
                //cnn.query("delete from HistorialKilometraje where IDVEHICULO=" + valor);
                cnn.query("delete from Mantenimiento where IDVEHICULO=" + valor);
                cnn.query("delete from DisponibilidadVehiculo where IDVEHICULO=" + valor);
                cnn.query("delete from VEHICULO where IDVEHICULO=" + valor);
                MessageBox.Show("Eliminado con exito!!");
            }
        }
    }
}

