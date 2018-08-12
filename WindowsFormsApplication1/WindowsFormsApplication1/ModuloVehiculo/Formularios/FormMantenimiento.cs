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
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.HistorialKilometraje' Puede moverla o quitarla según sea necesario.
            // this.historialKilometrajeTableAdapter.Fill(this.sistemaAAPDataSet.HistorialKilometraje);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.mantenimientoTableAdapter.Fill(this.sistemaAAPDataSet.Mantenimiento);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mantenimientoBindingSource.EndEdit();
                //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Vehiculo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kilometrajeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iDVEHICULOLabel_Click(object sender, EventArgs e)
        {

        }

        private void idVehiculoLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}