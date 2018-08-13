using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVehiculo.Clases
{
    class Disponibilidad
    {
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private string estado;
        private string descripcion;
        private string tipo_vehiculo;

        public Disponibilidad(DateTime fecha_inicio, DateTime fecha_fin, string estado, string descripcion, string tipo_vehiculo)
        {
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.estado = estado;
            this.descripcion = descripcion;
            this.tipo_vehiculo = tipo_vehiculo;

        }


        public string Obtener_disponibilidad()
        {
            return "";
        }
        public DateTime Getfecha_inicio()
        {
            return fecha_inicio;
        }
        public void Setfecha_inicio(DateTime fecha_inicio)
        {
            this.fecha_inicio=fecha_inicio;

        }
        public DateTime Getfecha_fin()
        {
            return fecha_fin;
        }
        public void Setfecha_fin(DateTime fecha_fin)
        {
            this.fecha_fin=fecha_fin;

        }
        public string Getestado()
        {
            return estado;
        }
        public void Setestado(string estado)
        {
            this.estado=estado;

        }
        public string Getdescripcion()
        {
            return descripcion;
        }
        public void Setdescripcion(string descripcion)
        {
            this.descripcion=descripcion;

        }
        public string Gettipo_vehiculo()
        {
            return tipo_vehiculo;
        }
        public void Setplaca(string tipo_vehiculo)
        {
            this.tipo_vehiculo=tipo_vehiculo;

        }
    }
}
