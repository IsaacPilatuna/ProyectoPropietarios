using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    class Autorizacion
    {
        public Boolean estado = false;
        public String fecha_autorizacion;

        LinkedList<string[]> list = new LinkedList<string[]>();
        string[] motivosValidos = { "Excursion", "Salida de campo", "Gira" };
        DateTime thisDay = DateTime.Today;



        public void autorizar(String reserva)
        {



            Conexion conect = new Conexion();
            MessageBox.Show("reserva"+reserva);
            conect.query(" update solicitudreserva set estadosolicitud='aprobada1' where idsolicitudreserva=" + reserva + ";");
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar("", "select idusuario,idMotivoviaje,fechasalida,fecharetorno from solicitudreserva where idsolicitudreserva= '" + reserva + "'");
            DataRow row = dtaux.Rows[0];
            String idusuario = Convert.ToString(row["idusuario"]);
            String fechaSalida = Convert.ToString(row["fechasalida"]);
            String fechaRetorno = Convert.ToString(row["fecharetorno"]);
            String idMotivoviaje = Convert.ToString(row["idMotivoviaje"]);



            DataTable dtaux2 = cn.Buscar("", "select email, nombre from usuarios where idusuario= '" + idusuario + "'");
            DataRow row2 = dtaux2.Rows[0];
            String email = Convert.ToString(row2["email"]);
            String nombre = Convert.ToString(row2["nombre"]);

            DataTable dtaux3 = cn.Buscar("", "select descripcion from motivoviaje where idmotivoviaje= '" + idMotivoviaje + "'");
            DataRow row3 = dtaux3.Rows[0];
            String motivoViaje = Convert.ToString(row3["descripcion"]);

            //MessageBox.Show("mi email del solicitante es" + email);
            NotificacionUsuario notificacion = new NotificacionUsuario();

            string cuerpo = "<html><head><style>body{ background - color: powderblue; } h1{ color:#FF0000; } p{ color: black; } </style ></head><body>"
                + "<h1> ESCUELA POLITECNICA NACIONAL</h1>"
                + "<h2> Gestión de transporte</h2>"
                + "<p>Estimado " + nombre + ", la solicitud de reserva N° " + reserva + " por motivo de '" + motivoViaje + "' con fecha de salida " + fechaSalida + " y fecha de retorno " + fechaRetorno + " ha sido aprobada, por favor espere la confirmación de la reserva.</p></body></html>";

            notificacion.NotificacionSolicitudAprobada(email, cuerpo);

        }
        public void rechazar(String reserva)
        {
            Conexion conect = new Conexion();

            conect.query(" update solicitudreserva set estadosolicitud='rechazada' where idsolicitudreserva=" + reserva + ";");
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar("", "select idusuario,idMotivoviaje,fechasalida,fecharetorno from solicitudreserva where idsolicitudreserva= '" + reserva + "'");
            DataRow row = dtaux.Rows[0];
            String idusuario = Convert.ToString(row["idusuario"]);
            String fechaSalida = Convert.ToString(row["fechasalida"]);
            String fechaRetorno = Convert.ToString(row["fecharetorno"]);
            String idMotivoviaje = Convert.ToString(row["idMotivoviaje"]);



            DataTable dtaux2 = cn.Buscar("", "select email, nombre from usuarios where idusuario= '" + idusuario + "'");
            DataRow row2 = dtaux2.Rows[0];
            String email = Convert.ToString(row2["email"]);
            String nombre = Convert.ToString(row2["nombre"]);

            DataTable dtaux3 = cn.Buscar("", "select descripcion from motivoviaje where idmotivoviaje= '" + idMotivoviaje + "'");
            DataRow row3 = dtaux3.Rows[0];
            String motivoViaje = Convert.ToString(row3["descripcion"]);

            //MessageBox.Show("mi email del solicitante es" + email);
            NotificacionUsuario notificacion = new NotificacionUsuario();

            string cuerpo = "<html><head><style>body{ background - color: powderblue; } h1{ color:#FF0000; } p{ color: black; } </style ></head><body>"
                + "<h1> ESCUELA POLITECNICA NACIONAL</h1>"
                + "<h2> Gestión de transporte</h2>"
                + "<p>Estimado " + nombre + ", la solicitud de reserva N° " + reserva + " por motivo de '" + motivoViaje + "' con fecha de salida " + fechaSalida + " y fecha de retorno " + fechaRetorno + " ha sido rechazada.</p></body></html>";

            notificacion.NotificacionSolicitudRechazada(email, cuerpo);



        }






    }
}
