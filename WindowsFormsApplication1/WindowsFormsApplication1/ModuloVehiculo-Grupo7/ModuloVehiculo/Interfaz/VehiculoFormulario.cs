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
    public partial class VehiculoFormulario : Form
    {
        private int valor;
        private ListaVehiculos lista= new ListaVehiculos();
        public VehiculoFormulario(int value)
        {
            InitializeComponent();
            this.valor = value;
            if (valor==1){
                btnHI.Visible = false;
                btnHM.Visible = false;
                btnModificar.Visible = false;
                btnImagenV.Enabled = false;
                txtAno.Enabled = true;
                txtCapacidad.Enabled = true;
                txtMatricula.Enabled = true;
                txtPlaca.Enabled = true;
                txtTipoV.Enabled = true;
            }
        }
        
        private void VehiculoFormulario_Load(object sender, EventArgs e)
        {
            hScrollBarDatos.Maximum = lista.Longitud_Lista();
        }

        private void hScrollBarDatos_ValueChanged(object sender, ScrollEventArgs e)
        {
            int a = hScrollBarDatos.Value;
            txtAno.Text = Convert.ToString(a);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            btnImagenV.Enabled = true;
            txtAno.Enabled = true;
            txtCapacidad.Enabled = true;
            txtMatricula.Enabled = true;
            txtPlaca.Enabled = true;
            txtTipoV.Enabled = true;
        }
    }
}
