using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloFormularios;

namespace ModuloFormularios
{
    public partial class Form2: Form
    {
        private CSReporteConductor reporteConductor;
        
        public Form2(string cedulaConductor, string nombresConductor)
        {
            InitializeComponent();
            reporteConductor = new CSReporteConductor();
            txt_ciConductor.Text = cedulaConductor;
            txt_nombreConductor.Text = nombresConductor;
        }

        private void obtenerDatos(object sender, EventArgs e)
        {
            try
            {
                reporteConductor.setDineroGastadoEnGasolina(Convert.ToSingle(txt_dinCombustible.Text));
                
                if (rb_inconvenienteT.Checked)
                {
                    reporteConductor.setDescripcionInconveniente(txt_descIncon.Text);

                }
                else
                {
                    reporteConductor.setDescripcionInconveniente("null");

                }

                if (rb_0.Checked)
                {
                    reporteConductor.setComportamientoPasajeros("0");
                }
                else if (rb_25.Checked)
                {
                    reporteConductor.setComportamientoPasajeros("25");
                }
                else if (rb_50.Checked)
                {
                    reporteConductor.setComportamientoPasajeros("50");
                }
                else if (rb_75.Checked)
                {
                    reporteConductor.setComportamientoPasajeros("75");
                }
                else
                {
                    reporteConductor.setComportamientoPasajeros("100");
                }
                reporteConductor.setIdConductor(txt_ciConductor.Text);
                reporteConductor.guardarEnBase();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al ingresar los datos");
                Console.WriteLine(er.ToString());
            }
        }

    }
 }

