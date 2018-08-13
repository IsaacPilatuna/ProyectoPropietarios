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
    public partial class dataMantenimiento : Form
    {
        public dataMantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);

        }

        private void dataMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataSetVehiculo.Mantenimiento);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mantenimientoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Incidencia",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
