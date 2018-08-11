using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class GestiónModulos
    {

        Cargo cargo = new Cargo();
        Usuario usuario = new Usuario();
        FormDatos frmDatos = new FormDatos();


        public GestiónModulos(FormMenu frm, String user)
        {


            obtenerDatosCargo(user);
            obtenerDatosUsuario(user);

            FormMenu frm1 = new FormMenu(user);
            privilegiosMenu(frm);
            frm1.iniciar(this);
            frm1.Show();

        }





        public void privilegiosMenu(FormMenu frm)
        {

            if (cargo.IDcargo1 == 1)
            {

                frm.btnReservas.Visible = true;
                frm.btnReportes.Visible = true;
                frm.btnNotificaciones.Visible = false;
                frm.btnVehículos.Visible = true;
                frm.btnRutas.Visible = true;
                frm.btnIncidencias.Visible = true;
                frm.btnForm.Visible = false;


            }
            else if (cargo.IDcargo1 == 2)
            {
                frm.btnReservas.Visible = true;
                frm.btnReportes.Visible = true;
                frm.btnNotificaciones.Visible = false;
                frm.btnVehículos.Visible = true;
                frm.btnRutas.Visible = true;
                frm.btnIncidencias.Visible = true;
                frm.btnForm.Visible = false;
            }
            else if (cargo.IDcargo1 == 3)
            {
                frm.btnReservas.Visible = false;
                frm.btnReportes.Visible = false;
                frm.btnNotificaciones.Visible = true;
                frm.btnVehículos.Visible = false;
                frm.btnRutas.Visible = false;
                frm.btnIncidencias.Visible = false;
                frm.btnForm.Visible = true;
            }
            else if (cargo.IDcargo1 == 4)
            {
                frm.btnReservas.Visible = false;
                frm.btnReportes.Visible = false;
                frm.btnNotificaciones.Visible = false;
                frm.btnVehículos.Visible = false;
                frm.btnRutas.Visible = false;
                frm.btnIncidencias.Visible = false;
                frm.btnForm.Visible = true;
            }
            else
            {
                frm.btnReservas.Visible = false;
                frm.btnReportes.Visible = false;
                frm.btnNotificaciones.Visible = false;
                frm.btnVehículos.Visible = true;
                frm.btnRutas.Visible = true;
                frm.btnIncidencias.Visible = true;
                frm.btnForm.Visible = true;
            }


            frm.lbCorreo.Text = usuario.Email;
            frm.lbID.Text = cargo.NombreCargo;
            frm.lbNombre.Text = usuario.Nombre;
        }



        public void obtenerDatosUsuario(String correo)
        {
            SqlDataReader obtener = usuario.obtenerDatos(correo);


            if (obtener.Read() == true)
            {
                usuario.IDusuario1 = obtener.GetInt32(0);
                usuario.Nombre = obtener.GetString(1);
                usuario.IDcargo1 = obtener.GetInt32(2);
                usuario.Departamento = obtener.GetString(3);
                usuario.Email = obtener.GetString(4);

            }
        }

        public void obtenerDatosCargo(String correo)
        {
            SqlDataReader obtener = cargo.obtenerDatos(correo);


            if (obtener.Read() == true)
            {
                cargo.IDcargo1 = obtener.GetInt32(0);
                cargo.NombreCargo = obtener.GetString(1);

            }

        }

    
        //*********************************************************************ATENCION***********************
        // AVISO

        //Está funcion abre un form en el panel Contenedor
        //Ojo usar esta función siempre para abrir su form 
        public void mostrarMódulo(FormMenu frmMenú, object formHijo)
        {

            if (frmMenú.panelContenedor.Controls.Count > 0)
                frmMenú.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            frmMenú.panelContenedor.Controls.Add(fh);
            frmMenú.panelContenedor.Tag = fh;
            fh.Show();
        }

        public void mostrarDatos(FormMenu frmMenú)
        {

            privilegiosDatos();
            mostrarMódulo(frmMenú, frmDatos);
        }


        public void privilegiosDatos()
        {
            if (cargo.IDcargo1 == 1)
            {
                frmDatos.bGuardar.Visible = true;
                frmDatos.btnLimpiar.Visible = true;
               


            }
            else if (cargo.IDcargo1 == 2)
            {
                frmDatos.bGuardar.Visible = false;
                frmDatos.btnLimpiar.Visible = false;

            }
            else if (cargo.IDcargo1 == 3)
            {
                frmDatos.bGuardar.Visible = false;
                frmDatos.btnLimpiar.Visible = false;
            }
            else if (cargo.IDcargo1 == 4)
            {
                frmDatos.bGuardar.Visible = false;
                frmDatos.btnLimpiar.Visible = false;
            }
            else
            {
                frmDatos.bGuardar.Visible = false;
                frmDatos.btnLimpiar.Visible = false;
            }

           


        }
    }


}
