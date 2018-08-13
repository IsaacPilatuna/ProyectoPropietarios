using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloVehiculo_Grupo7.Interfaz
{
    public partial class HistorialIn : Form
    {
        string idvehiculo;
        Conexion3 cn = new Conexion3();
        public HistorialIn(string vehiculo)
        {
            this.idvehiculo = vehiculo;
            InitializeComponent();
        }

        private void HistorialIn_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAAPDataSet.IncidenciaVehiculo' Puede moverla o quitarla según sea necesario.
            cn.llenargrid(dataGridView1, "SELECT idIncidenciaVehiculo, descripcion, IDVEHICULO, hora, fecha FROM dbo.IncidenciaVehiculo WHERE(IDVEHICULO = " + idvehiculo + ")");


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            HistorialIn.ActiveForm.Visible = false;
        }
    }
}
