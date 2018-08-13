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
using WindowsFormsApplication1;

namespace ModuloVehiculo.Interfaz
{
    public partial class FormularioIngresoIM : Form
    {
        Conexion3 cnn = new Conexion3();
        public FormularioIngresoIM()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (verificarvacio() == 0)
            {
                Mantenimiento man = new Mantenimiento(float.Parse(txtKilometraje.Text),txtEA.Text as string, float.Parse(txtTUso.Text), datFecha.Value);
                man.Regitrar_Mantenimiento();
                MessageBox.Show("Registro de mantenimiento existos!!!");
                FormularioIngresoIM.ActiveForm.Visible = false;
            }
            
        }
        public int verificarvacio()
        {
            int contador = 0;
            string mss = "Error en el proceso, verifique que esten llenos los siguientes campos:";
            if (txtEA.Text.Equals(""))
            {
                contador++;
                mss += "\n- Estado del Aceite ";
            }
            if (txtTUso.Text.Equals(""))
            {
                contador++;
                mss += "\n- Tiempo de Uso ";
            }
            if (txtKilometraje.Text.Equals(""))
            {
                contador++;
                mss += "\n- Kilomentraje";
            }

            if (contador > 0)
                MessageBox.Show(mss);
            return contador;
        }
    }
}
