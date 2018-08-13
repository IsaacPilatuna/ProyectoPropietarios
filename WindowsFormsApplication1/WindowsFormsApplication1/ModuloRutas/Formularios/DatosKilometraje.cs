using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    public partial class DatosKilometraje : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public DatosKilometraje()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatosKilometraje_Load(object sender, EventArgs e)
        {
            con.CargarDatosKilometraje(dataKilometraje);
        }
    }
}
