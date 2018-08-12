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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void vEHICULOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICULOBindingSource.EndEdit();
            //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void vEHICULOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICULOBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            // this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);

        }

        private void pLACAVEHICULOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string hola = this.pLACAVEHICULOComboBox.GetItemText(this.pLACAVEHICULOComboBox.SelectedItem);
           // CustomersTableAdapter.Fill(CustomersDataTable)).

        }

        private void iDVEHICULOLabel_Click(object sender, EventArgs e)
        {

        }

        private void iDVEHICULOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pLACAVEHICULOLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
