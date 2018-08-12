using System;
using System.Data;
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
        //los dos parametros, solo la idSolcitutdAprobada, y true -> SI salvoconducto, caso contrario false 
        public void notificacionReservaAprobada(String idReservaAprobada, Boolean salvoconducto)
        {
            Conexion cn = new Conexion();
            DataTable dtaux = cn.Buscar("", "select idvehiculo,idchofer,idsolicitante,idsolicitudreserva from reservaaprobada where idreservaaprob=" + idReservaAprobada);

            DataRow row = dtaux.Rows[0];
            String idvehiculo = Convert.ToString(row["idvehiculo"]);
            String idchofer = Convert.ToString(row["idchofer"]);
            String idusuario = Convert.ToString(row["idsolicitante"]);
            String idSolicitudOriginal = Convert.ToString(row["idsolicitudreserva"]);

            DataTable dtaux2 = cn.Buscar("", "select fechasalida,lugar,idmotivoviaje from solicitudreserva where idsolicitudreserva=" + idSolicitudOriginal);
            DataRow row2 = dtaux2.Rows[0];
            String fechasalida = Convert.ToString(row2["fechasalida"]);//
            String lugar = Convert.ToString(row2["lugar"]);//
            String idmotivo = Convert.ToString(row2["idmotivoviaje"]);//

            DataTable dtaux3 = cn.Buscar("", "select nombrecompleto from chofer where idchofer=" + idchofer);
            DataRow row3 = dtaux3.Rows[0];
            String nombreChofer = Convert.ToString(row3["nombrecompleto"]);//

            DataTable dtaux4 = cn.Buscar("", "select nombre,email from usuarios where idusuario=" + idusuario);
            DataRow row4 = dtaux4.Rows[0];
            String nombreUsuario = Convert.ToString(row4["nombre"]);//
            String email = Convert.ToString(row4["email"]);//

            DataTable dtaux5 = cn.Buscar("", "select tipovehiculo,placavehiculo from vehiculo where idvehiculo=" + idvehiculo);
            DataRow row5 = dtaux5.Rows[0];
            String tipovehiculo = Convert.ToString(row5["tipovehiculo"]);//
            String placavehiculo = Convert.ToString(row5["placavehiculo"]);//

            DataTable dtaux6 = cn.Buscar("", "select descripcion from motivoviaje where idmotivoviaje=" + idmotivo);
            DataRow row6 = dtaux6.Rows[0];
            String motivo = Convert.ToString(row6["descripcion"]);//


            String salvoC = "";
            if (salvoconducto)
            {
                salvoC = "SI";
            }
            else
            {
                salvoC = "NO";
            }


            string cuerpo = "<html><head><style>body{ background - color: powderblue; } h1{ color:#FF0000; } p{ color: black; } </style ></head><body>"
                + "<h1> ESCUELA POLITECNICA NACIONAL</h1>"
                + "<h2> Gestión de transporte</h2>"
                + "<p>Estimado(a) " + nombreUsuario + ", ha sido aprobada la reserva en respuesta a la solicitud N° " + idSolicitudOriginal + " para el transporte hacia " + lugar + " (SALVOCONDUCTO=" + salvoC + ") por motivo de '" + motivo + "' con fecha de salida " + fechasalida + ". Se le ha asignado el vehiculo tipo " + tipovehiculo + " con placa " + placavehiculo + ". Su chofer designado es el/la sr(a) " + nombreChofer + ".</p></body></html>";


            c.enviarCorreoNotificacion(email, "RESERVA APROBADA", cuerpo);
        }


        //El parametro es la iD de la solictud original, es decir de la tabla 'SolicitudReserva', luego cambiarle el estado a 'rechazada'
        public void notificacioReservaRechazada(String idSolicitudRechazada)
        {
            Conexion cn = new Conexion();
            DataTable dtaux1 = cn.Buscar("", "select idusuario,lugar,idmotivoviaje from solicitudreserva where idsolicitudreserva=" + idSolicitudRechazada);
            DataRow row1 = dtaux1.Rows[0];

            String idusuario = Convert.ToString(row1["idusuario"]);//
            String lugar = Convert.ToString(row1["lugar"]);//
            String idmotivo = Convert.ToString(row1["idmotivoviaje"]);//

            DataTable dtaux2 = cn.Buscar("", "select nombre,email from usuarios where idusuario=" + idusuario);
            DataRow row2 = dtaux2.Rows[0];

            String nombre = Convert.ToString(row2["nombre"]);//
            String email = Convert.ToString(row2["email"]);//


            DataTable dtaux3 = cn.Buscar("", "select descripcion from motivoviaje where idmotivoviaje=" + idmotivo);
            DataRow row3 = dtaux3.Rows[0];

            String motivo = Convert.ToString(row3["descripcion"]);//



            string cuerpo = "<html><head><style>body{ background - color: powderblue; } h1{ color:#FF0000; } p{ color: black; } </style ></head><body>"
                + "<h1> ESCUELA POLITECNICA NACIONAL</h1>"
                + "<h2> Gestión de transporte</h2>"
                + "<p>Estimado(a) " + nombre + ",se ha rechazado la reserva en respuesta a la solicitud N° " + idSolicitudRechazada + " para el transporte hacia " + lugar + " por motivo de '" + motivo + "'. Gracias.</p></body></html>";

            c.enviarCorreoNotificacion(email, "RESERVA RECHAZADA", cuerpo);
        }
    }
}
