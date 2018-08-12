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
        
        public Form2(string idConductor, string nombresConductor, string [] reservas)
        {
            InitializeComponent();
            crearCombo(reservas);
            reporteConductor = new CSReporteConductor();
            txt_idConductor.Text = idConductor;
            txt_nombreConductor.Text = nombresConductor;
        }
        public void crearCombo(string[] reservas) {

            foreach (string reserva in reservas)
            {
                cb_reservas.Items.Add(reserva);
            }
                         

        }
        private void obtenerDatos(object sender, EventArgs e)
        {
            try
            {
                if (cb_reservas.SelectedItem != null)
                {
                    reporteConductor.setIdReservaAprobada(cb_reservas.SelectedItem + "");
                    reporteConductor.setNombreCompletoConducto(txt_nombreConductor.Text);
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
                    reporteConductor.setIdReservaAprobada(cb_reservas.SelectedItem + "");
                    //MessageBox.Show(reporteConductor.getIdReservaAprobada() + " " + txt_idConductor.Text + " " + reporteConductor.getNombreCompletoConductor()
                    //  + " " + rb_inconvenienteT.Checked + " " + rb_inconvenienteF.Checked + " " + reporteConductor.getDescripcionInconveniente() + " " +
                    // reporteConductor.getDineroGastadoEnGasolina() + " " + reporteConductor.getComportameientoPasajeros());
//
                    reporteConductor.guardarEnBase();
                }
                else {
                    MessageBox.Show("ERROR AL INGRESAR LOS DATOS");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERROR AL INGRESAR LOS DATOS");
                         }
        }

        private void rb_inconvenienteF_CheckedChanged(object sender, EventArgs e)
        {
            txt_descIncon.Enabled = false;
        }

        private void rb_inconvenienteT_CheckedChanged(object sender, EventArgs e)
        {
            txt_descIncon.Enabled = true;
        }
    }
 }

