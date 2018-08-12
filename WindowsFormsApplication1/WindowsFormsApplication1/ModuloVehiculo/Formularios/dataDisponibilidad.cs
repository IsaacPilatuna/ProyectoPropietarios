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
            //this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet);

        }

        private void dataDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.DisponibilidadVehiculo' Puede moverla o quitarla según sea necesario.
            //this.disponibilidadVehiculoTableAdapter.Fill(this.sistemaAAPDataSet.DisponibilidadVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void disponibilidadVehiculoBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disponibilidadVehiculoBindingSource1.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.sistemaAAPDataSet1);

        }

        private void dataDisponibilidad_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet1.DisponibilidadVehiculo' Puede moverla o quitarla según sea necesario.
            //this.disponibilidadVehiculoTableAdapter.Fill(this.sistemaAAPDataSet1.DisponibilidadVehiculo);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
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

