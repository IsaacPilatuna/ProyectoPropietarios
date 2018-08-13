using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Reserva
    {

        private int idReserva;
        private int idMotivoViaje;
        private int idCategoriaUsuario;//categoria usuario
        private int numeroPersonas;
        private string fechaInicio;
        private string fechaFin;
        private string estado;
        private int idSolicitante;
        private string nombreSolicitante;
        private string destino;
        Conexion coneccion;
        Viaje viaje;

        public Reserva()
        {

            coneccion = new Conexion();
            viaje = new Viaje();

        }


        public int NumeroPersonas
        {
            get
            {
                return numeroPersonas;
            }

            set
            {
                numeroPersonas = value;
            }
        }



        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FechaFin
        {
            get
            {
                return fechaFin;
            }

            set
            {
                fechaFin = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int IdReserva
        {
            get
            {
                return idReserva;
            }

            set
            {
                idReserva = value;
            }
        }

        public int IdMotivoViaje
        {
            get
            {
                return idMotivoViaje;
            }

            set
            {
                idMotivoViaje = value;
            }
        }

        public int IdCategoriaUsuario
        {
            get
            {
                return idCategoriaUsuario;
            }

            set
            {
                idCategoriaUsuario = value;
            }
        }

        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
            }
        }

        public string NombreSolicitante { get => nombreSolicitante; set => nombreSolicitante = value; }
        public string Destino { get => destino; set => destino = value; }

        public bool confirmarViaje()
        {
            Boolean cv= false;
            viaje.asignarFecha(this.FechaInicio, this.FechaFin);
            viaje.asignarChofer(this.NumeroPersonas);
            viaje.asignarVehiculo(this.NumeroPersonas);


            if (viaje.validarChoferVehiculo(viaje.asignarChofer(this.NumeroPersonas), viaje.asignarVehiculo(this.NumeroPersonas)))
            {
                cv = true;
                registrarReservaAprovada();
            }

            return cv;
        }

        public void registrarReservaAprovada()
        {
            this.estado = "aprobada2";
            coneccion.Conectar();
            Console.WriteLine(this.fechaInicio);
            SqlCommand cmd = new SqlCommand("INSERT INTO RESERVAAPROBADA ( IDCHOFER,IDVEHICULO,IDMOTIVOVIAJE,IDSOLICITANTE,NUMEROPERSONAS,FECHASALIDA,FECHARETORNO,ESTADOSOLICITUD, IDSOLICITUDRESERVA) VALUES (" + viaje.Chofer.IdChofer + "," + viaje.Vehiculo.IdVehiculo + "," + this.idMotivoViaje + "," + this.idCategoriaUsuario + "," + this.numeroPersonas + ",'" + this.fechaInicio + "','" + this.fechaFin + "', '" + this.estado + "'," + this.idReserva + ") ", coneccion.getConnection());
            cmd.ExecuteNonQuery();

        }

        public void reservar(Reserva reserva)
        {
            
            if (reserva.confirmarViaje())
            {
                bool aux = true;
                String[] destinoAux;

                reserva.Estado = "aprobada2";
                SqlCommand cmd = new SqlCommand("UPDATE SolicitudReserva SET estadoSolicitud= '" + reserva.Estado + "' WHERE idSolicitudReserva=" + reserva.IdReserva, coneccion.getConnection());
                cmd.ExecuteNonQuery();

                String reservaAprobada;
                SqlCommand cmdAux = new SqlCommand("select IDRESERVAAPROB from RESERVAAPROBADA WHERE IDSOLICITUDRESERVA =" + reserva.idReserva, coneccion.getConnection());
                reservaAprobada=cmdAux.ExecuteScalar().ToString();

                Console.WriteLine(reservaAprobada);
                coneccion.Desconectar();

                destinoAux = reserva.Destino.Split(',');

                if (destinoAux.Last() == "Pichincha")
                {
                    aux = false;
                }
                
                NotificacionUsuario notificacion = new NotificacionUsuario();
                notificacion.notificacionReservaAprobada(reservaAprobada,aux);

                MessageBox.Show("Reserva Aprobada", "Aprobada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE SolicitudReserva SET estadoSolicitud= 'rechazado' WHERE idSolicitudReserva=" + reserva.IdReserva, coneccion.getConnection());
                cmd.ExecuteNonQuery();
                
                NotificacionUsuario notificacion = new NotificacionUsuario();
                notificacion.notificacioReservaRechazada(reserva.IdReserva.ToString());

                MessageBox.Show("Reserva rechazada", "Reserva",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
