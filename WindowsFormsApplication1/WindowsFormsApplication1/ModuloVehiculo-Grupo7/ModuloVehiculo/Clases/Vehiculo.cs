using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVehiculo.Clases
{
    class Vehiculo
    {
        private int id_vehiculo;
        private string placa;
        private string matricula;
        private string modelo;
        private string tipo_vehiculo;
        private int num_pasajero;

        public Vehiculo(string placa, string matricula, string modelo, string Tipo_V, int num_pasajeros)
        {
            this.placa = placa;
            this.matricula = matricula;
            this.modelo = modelo;
            this.tipo_vehiculo = Tipo_V;
            this.num_pasajero = num_pasajeros;
        }

        public void Registrar_Vehiculo(string placa, string matricula, string modelo, string Tipo_V, int num_pasajeros)
        {

        }

        public string Buscar_Vehiculo(string placa)
        {
            return "";
        }

        public int Getid_vehiculo()
        {
            return id_vehiculo;
        }
        public void Setid_vehiculo(int id_vehiculo)
        {
            this.id_vehiculo=id_vehiculo;

        }
        public string Getplaca()
        {
            return placa;
        }
        public void Setplaca(string placa)
        {
            this.placa = placa;

        }
        public string Getmatricula()
        {
            return matricula;
        }
        public void Setmatricula(string matricula)
        {
            this.matricula=matricula;

        }
        public string Getmodelo()
        {
            return modelo;
        }
        public void Setmodelo(string modelo)
        {
            this.modelo=modelo;

        }
        public string Gettipo_vehiculo()
        {
            return tipo_vehiculo;
        }
        public void Settipo_vehiculo(string tipo_vehiculo)
        {
            this.tipo_vehiculo=tipo_vehiculo;

        }
        public int Getnum_pasajero()
        {
            return num_pasajero;
        }
        public void Setnum_pasajero(int num_pasajero)
        {
            this.num_pasajero=num_pasajero;

        }
        
    }
}
