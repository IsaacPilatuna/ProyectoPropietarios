using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    public partial class dataDisponibilidad : Form
    {
        public dataDisponibilidad()
        {
            InitializeComponent();
        }

        private void disponibilidadVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disponibilidadVehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);

        }

        private void dataDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.DisponibilidadVehiculo' Puede moverla o quitarla según sea necesario.
            this.disponibilidadVehiculoTableAdapter.Fill(this.dataSetVehiculo.DisponibilidadVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.disponibilidadVehiculoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Incidencia",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void disponibilidadVehiculoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void disponibilidadVehiculoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
