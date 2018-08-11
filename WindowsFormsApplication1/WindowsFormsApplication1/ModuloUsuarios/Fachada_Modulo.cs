using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloFormularios;
using WindowsFormsApplication1.ModuloReportesEstadisticos;
using WindowsFormsApplication1.ModuloVehiculo.Formularios;

namespace WindowsFormsApplication1
{
    public class Fachada_Modulo
    {

        Cargo cargo = new Cargo();
        Usuario usuario = new Usuario();
        FormDatos frmDatos = new FormDatos();
        mdiModVehiculo frmVehi = new mdiModVehiculo();
        solicitudesPendientes solicitudes;
        PrincipalFormularioProfesor FormulariosProfesor = new PrincipalFormularioProfesor();
        String aux; 

        //FrmReporteHistorialKilometraje frmRep


        public Fachada_Modulo(FormMenu frm, String user)
        {


            obtenerDatosCargo(user);
            obtenerDatosUsuario(user);
            aux = user;

            FormMenu frm1 = new FormMenu(user);
            privilegiosMenu(frm);
            frm1.iniciar(this);
            frm1.Show();

        }





        public void privilegiosMenu(FormMenu frm)
        {

            if (cargo.IDcargo1 == 1)
            {
                frm.btnNotificaciones.Visible = true;
                frm.btnReportes.Visible = true;
                frm.btnRutas.Visible = true;
                frm.btnUser.Visible = true;
                frm.btnVehículos.Visible = true;


            }
            else if (cargo.IDcargo1 == 2)
            {

            }
            else if (cargo.IDcargo1 == 3)
            {

            }
            else if (cargo.IDcargo1 == 4)
            {
                frm.btnNotificaciones.Visible = false;
                frm.btnReportes.Visible = false;
                frm.btnRutas.Visible = false;
                frm.btnUser.Visible = false;
                frm.btnVehículos.Visible = false;
            }
            else
            {
                frm.btnNotificaciones.Visible = false;
                frm.btnReportes.Visible = false;
                frm.btnRutas.Visible = true;
                frm.btnUser.Visible = false;
                frm.btnVehículos.Visible = true;
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
        public void mostrarNotificaciones(FormMenu frmMenu)
        {
            solicitudes = new solicitudesPendientes(aux);
            mostrarMódulo(frmMenu, solicitudes);
        }
        public void mostrarFormulario(FormMenu frmMenu)
        {
            FormulariosProfesor = new PrincipalFormularioProfesor();
            mostrarMódulo(frmMenu, FormulariosProfesor);
        }
        public void mostrarDatos(FormMenu frmMenú)
        {

            privilegiosDatos();
            mostrarMódulo(frmMenú, frmDatos);
        }


        public void mostrarModvehiculo(FormMenu frmMenú)
        {
            mostrarMódulo(frmMenú, frmVehi);

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
