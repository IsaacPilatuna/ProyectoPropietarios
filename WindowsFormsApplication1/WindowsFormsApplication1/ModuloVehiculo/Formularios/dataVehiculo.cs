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
            // this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void dataVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            //this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void vEHICULODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vEHICULOBindingSource.EndEdit();
                //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Vehiculo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
        }
    }
}
