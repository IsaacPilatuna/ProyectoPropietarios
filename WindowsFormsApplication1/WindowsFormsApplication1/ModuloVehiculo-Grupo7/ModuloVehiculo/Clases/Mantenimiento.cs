using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVehiculo.Clases
{
    class Mantenimiento
    {
        private int id_vehiculo;
        private int idmatenimiento;
        private float kilometraje;
        private string estado_aceite;
        private float tiempo_uso;
        private DateTime fecha_mantenimiento;

        public Mantenimiento(float kilometraje, string estado_aceite, float tiempo_uso, DateTime fecha_mantenimiento)
        {
            this.kilometraje = kilometraje;
            this.estado_aceite = estado_aceite;
            this.tiempo_uso = tiempo_uso;
            this.fecha_mantenimiento = fecha_mantenimiento;
        }

        public void Verificar_Mantenimiento()
        {

        }

        public float Getkilomentraje()
        {
            return kilometraje;
        }
        public void Setkilomentraje(float kilometraje)
        {
            this.kilometraje=kilometraje;

        }
        public string Getestado_aceite()
        {
            return estado_aceite;
        }
        public void Setestado_aceite(string estado_aceite)
        {
            this.estado_aceite = estado_aceite;

        }
        public float Gettiempo_uso()
        {
            return tiempo_uso;
        }
        public void Settiempo_uso(float tiempo_uso)
        {
            this.tiempo_uso=tiempo_uso;

        }
        public DateTime Getfecha_mantenimiento()
        {
            return fecha_mantenimiento;
        }
        public void Setfecha_mantenimiento(DateTime fecha_mantenimiento)
        {
            this.fecha_mantenimiento=fecha_mantenimiento;

        }

    }
}
