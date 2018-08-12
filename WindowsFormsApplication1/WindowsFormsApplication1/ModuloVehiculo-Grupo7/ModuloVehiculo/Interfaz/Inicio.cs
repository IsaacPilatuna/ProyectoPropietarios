using ModuloVehiculo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVehiculo.Interfaz
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            VehiculoFormulario vf = new VehiculoFormulario(1);
            vf.Show();
            
        }

        private void bntQuery_Click(object sender, EventArgs e)
        {
            VehiculoFormulario vf = new VehiculoFormulario(2);
            vf.Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            VehiculosDelte vd = new VehiculosDelte ();
            vd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            toolTip1.SetToolTip(btnADD, "Añadir: Permite agregar un nuevo vehiculo");
            toolTip1.SetToolTip(btnDelete, "Eliminar: Permite eliminar un vehiculo");
            toolTip1.SetToolTip(btnExit, "Salir: Permite salir del módulo");
            toolTip1.SetToolTip(bntQuery, "Consultar: Permite consultar los vehiculos existente y modificar su información");
        }
    }
}
