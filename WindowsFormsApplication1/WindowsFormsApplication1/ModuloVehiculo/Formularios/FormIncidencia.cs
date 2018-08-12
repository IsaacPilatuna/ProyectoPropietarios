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
    public partial class FormIncidencia : Form
    {
        public FormIncidencia()
        {
            InitializeComponent();
        }

        private void incidenciaVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.incidenciaVehiculoBindingSource.EndEdit();
                // this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);
            }
            catch
            {
                MessageBox.Show("Campos llenados erroneamente", "Incidencia",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            incidenciaVehiculoBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = true;

        }

        private void FormIncidencia_Vehiculocs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.VEHICULO' Puede moverla o quitarla según sea necesario.
            // this.vEHICULOTableAdapter.Fill(this.sistemaAAPDataSet.VEHICULO);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.IncidenciaVehiculo' Puede moverla o quitarla según sea necesario.
            //this.incidenciaVehiculoTableAdapter.Fill(this.sistemaAAPDataSet.IncidenciaVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            incidenciaVehiculoBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
