using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloVehiculo_Grupo7.Interfaz
{
    public partial class HistoMan : Form
    {
        string idvehiculo;
        Conexion3 cn = new Conexion3();
        public HistoMan(string idvehiculo)
        {
            this.idvehiculo = idvehiculo;
            InitializeComponent();
        }

        private void HistoMan_Load(object sender, EventArgs e)
        {
            cn.llenargrid(dataGridView1, "SELECT idMantenimiento, estado_banda, kilometraje, IDVEHICULO, fecha_mantenimiento, tiempo_uso FROM Mantenimiento WHERE(IDVEHICULO = " + idvehiculo + ")");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            HistoMan.ActiveForm.Visible = false;
        }
    }
}
