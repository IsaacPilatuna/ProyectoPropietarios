using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{

    
    class NotificacionUsuario : Notificacion
    {
                Correo c = new Correo();

        public void NotificacionSolicitudAprobada(string correo,  string cuerpo)
        {
            c.enviarCorreoNotificacion(correo, "SOLICITUD APROBADA", cuerpo);
        }
        public void NotificacionSolicitudRechazada(string correo,  string cuerpo)
        {
            c.enviarCorreoNotificacion(correo, "SOLICITUD RECHAZADA", cuerpo);
        }
        public void notificacionReservaAprobada(String correo, String cuerpo)
        {
            c.enviarCorreoNotificacion(correo, "RESERVA ARPOBADA", cuerpo);
        }
        public void notificacioReservaRechazada(String correo, String cuerpo)
        {
            c.enviarCorreoNotificacion(correo, "RESERVA RECHAZADA", cuerpo);
        }
    }
}
