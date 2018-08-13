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
    
    public partial class DatosIncidencia : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        string placa;
        public DatosIncidencia()
        {
            InitializeComponent();
        }

        private void dataIncidecia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.CargarDatos(placa,dataIncidecia);
        }

        private void CBPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DatosIncidencia_Load(object sender, EventArgs e)
        {

            //con.CargarDatos(placa, dataIncidecia);
            this.MostrarIncidencia(dataIncidecia);
        }

        public void MostrarIncidencia(DataGridView dat)
        {
            con.CargarDatosKilometraje(dat);
        }
    }
}
