using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVehiculo.Clases
{
    class Incidencia
    {
        private int idincidencia;
        private DateTime hora;
        private DateTime fecha_ind;
        private string placa;
        private string descripcion;

        public Incidencia(int idincidencia,DateTime fecha,DateTime fechaind, string placa, string descripcion)
        {
            this.idincidencia = idincidencia;
            this.hora = fecha;
            this.fecha_ind = fechaind;
            this.placa = placa;
            this.descripcion = descripcion;
        }

        public void Registrar_incidencia()
        {

        }
        public string Buscar_Incidencia(string placa)
        {
            return "";
        }
        public void Verificar_Incidencia()
        {

        }
        public int Getidincidencia()
        {
            return idincidencia;
        }
        public void Setidincidencia(int incidencia)
        {
            this.idincidencia = incidencia;

        }
        public DateTime Gethora()
        {
            return hora;
        }
        public void Sethora(DateTime hora)
        {
            this.hora=hora;

        }
        public DateTime Getfecha_inc()
        {
            return fecha_ind;
        }
        public void Settipo_vehiculo(DateTime fecha_ind)
        {
            this.fecha_ind=fecha_ind;

        }
        public string Getplaca()
        {
            return placa;
        }
        public void Setplaca(string placa)
        {
            this.placa = placa;

        }
        public string Getdescripcion()
        {
            return descripcion;
        }
        public void Setdescripcion(string descripcion)
        {
            this.descripcion=descripcion;

        }
    }
}
