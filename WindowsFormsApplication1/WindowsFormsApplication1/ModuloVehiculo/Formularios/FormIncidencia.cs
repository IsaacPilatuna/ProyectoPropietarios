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
    public partial class FormIncidencia : Form
    {
        public FormIncidencia()
        {
            InitializeComponent();
        }

        private void incidenciaVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidenciaVehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);

        }

        private void FormIncidencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.IncidenciaVehiculo' Puede moverla o quitarla según sea necesario.
            this.incidenciaVehiculoTableAdapter.Fill(this.dataSetVehiculo.IncidenciaVehiculo);

        }
    }
}
