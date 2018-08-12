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
namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    public partial class dataIncidencias : Form
    {
        public dataIncidencias()
        {
            InitializeComponent();
        }

        private void incidenciaVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidenciaVehiculoBindingSource.EndEdit();
            //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void dataIncidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.incidencia' Puede moverla o quitarla según sea necesario.
            //this.incidenciaTableAdapter.Fill(this.sistemaAAPDataSet.incidencia);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.IncidenciaVehiculo' Puede moverla o quitarla según sea necesario.
            //this.incidenciaVehiculoTableAdapter.Fill(this.sistemaAAPDataSet.IncidenciaVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void incidenciaVehiculoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.incidenciaVehiculoBindingSource.EndEdit();
                //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Incidencia",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
