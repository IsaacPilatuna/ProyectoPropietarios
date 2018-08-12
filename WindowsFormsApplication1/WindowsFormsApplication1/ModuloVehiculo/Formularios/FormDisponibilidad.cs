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
    public partial class FormDisponibilidad : Form
    {
        public FormDisponibilidad()
        {
            InitializeComponent();
        }

        private void disponibilidadVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.disponibilidadVehiculoBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Campos llenados erroneamente", "Disponibilidad",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            disponibilidadVehiculoBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = true;

        }

        private void FormDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            // this.mantenimientoTableAdapter.Fill(this.sistemaAAPDataSet.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            //this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            //this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.DisponibilidadVehiculo' Puede moverla o quitarla según sea necesario.
            //this.disponibilidadVehiculoTableAdapter.Fill(this.sistemaAAPDataSet.DisponibilidadVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            disponibilidadVehiculoBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;

        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.disponibilidadVehiculoBindingSource.EndEdit();
                //  this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Necesario dejar almenos un registro ", "Disponibilidad",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
        }

        
    }
}
