using ModuloFormularios;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloReportesEstadisticos;


namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Correo cor = new Correo();

            Conexion conect = new Conexion();
            //simuladorLogin log = new simuladorLogin();
            // log.ShowDialog();
            // Hola a todos esta es la tercera prueba

            // conect.query("insert into NotificacionRuta values ('rut2','2-jun-2019');");
            // conect.abrir();
            //conect.query(" update solicitudreserva set estadosolicitud='aprobada1' where idsolicitudreserva=1;");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ////PRUEBAS UNITARIAS
            //Application.Run(new FrmReporteHistorialKilometraje());

            //simuladorLogin log = new simuladorLogin();
            //log.ShowDialog();


           Application.Run(new FormLogin());
       



            //SIMULACION LOGIN

            
        

        }
    }
}
