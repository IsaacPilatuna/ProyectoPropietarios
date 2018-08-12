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
    public partial class FrmCalificacionServicio : Form
    {
        private CSCalificacionDeServicio calificacionServicio;

        public FrmCalificacionServicio(string idUsuario, string nombre, string [] reservas)
        {
            InitializeComponent();
            calificacionServicio = new CSCalificacionDeServicio();
            crearCombo(reservas);
            txt_nomConductor.Text= nombre;
        }

        public void crearCombo(string[] reservas)
        {
            foreach (string reserva in reservas)
            {
                cb_reservas.Items.Add(reserva);
                cb_reservas.SelectedItem = 2;
            }

        }
       
        private void obtenerDatos(object sender, EventArgs e)
        {
            if (cb_reservas.SelectedItem != null)
            {
                calificacionServicio.setIdReserva(cb_reservas.SelectedItem+"");
                if (rb_puntSalidaT.Checked)
                {
                    calificacionServicio.setPuntualSalida("SI");
                }
                else
                {
                    calificacionServicio.setPuntualSalida("NO");
                }

                if (rb_limpiezaT.Checked)
                {
                    calificacionServicio.setLimpiezaVehiculo("SI");
                }
                else
                {
                    calificacionServicio.setLimpiezaVehiculo("NO");
                }
                if (rb_puntLlegadaT.Checked)
                {
                    calificacionServicio.setPuntualAlDestino("SI");
                }
                else
                {
                    calificacionServicio.setPuntualAlDestino("NO");
                }

                if (rb_puntRetornoT.Checked)
                {
                    calificacionServicio.setPuntualAlRetorno("SI");
                }
                else
                {
                    calificacionServicio.setPuntualAlRetorno("NO");
                }
                if (!txt_comenAdicionales.Text.Equals(""))
                {
                    calificacionServicio.setComentariosAdicionales(txt_comenAdicionales.Text);
                }
                else {
                    calificacionServicio.setComentariosAdicionales(null);
                }
                //MessageBox.Show(calificacionServicio.getPuntualAlDestino() + " " + calificacionServicio.getPuntualAlRetorno() + " " +
                //                    calificacionServicio.getLimpiezaVehiculo() + " " + calificacionServicio.getPuntualSalida() + calificacionServicio.getComentariosAdicionales()
                //    + " " + txt_nomConductor.Text + " " + cb_reservas.SelectedItem);
                calificacionServicio.guardarEnBase();
            }
            else{ 
                MessageBox.Show("ERROR AL INGRESAR LOS DATOS");

            }
        }
    }
}
