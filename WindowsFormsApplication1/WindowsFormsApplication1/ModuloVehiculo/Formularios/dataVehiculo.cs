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
    public partial class dataVehiculo : Form
    {
        public dataVehiculo()
        {
            InitializeComponent();
        }

        private void vEHICULOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICULOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);

        }

        private void dataVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.VEHICULO' Puede moverla o quitarla según sea necesario.
            this.vEHICULOTableAdapter.Fill(this.dataSetVehiculo.VEHICULO);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vEHICULOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Vehiculo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
        }
    }
}
