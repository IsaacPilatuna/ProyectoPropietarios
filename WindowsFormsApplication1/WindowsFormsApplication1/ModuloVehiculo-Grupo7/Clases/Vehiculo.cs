using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ModuloVehiculo.Clases
{
    class Vehiculo
    {
        private int id_vehiculo;
        private string placa;
        private string matricula;
        // private string modelo { get; set; }
        private int anio;
        private string tipo_vehiculo;
        private int num_pasajero;
        Conexion3 conn = new Conexion3();

        //public Vehiculo(string placa, string matricula, string modelo, string Tipo_V, int num_pasajeros, int anio)
        public Vehiculo(string placa, string matricula, string Tipo_V, int num_pasajeros, int anio, int id_vehiculo)
        {
            this.placa = placa;
            this.matricula = matricula;
            //this.modelo = modelo;
            this.tipo_vehiculo = Tipo_V;
            this.num_pasajero = num_pasajeros;
            this.anio = anio;
            this.id_vehiculo = id_vehiculo;
        }
        public Vehiculo(string placa, string matricula, string Tipo_V, int num_pasajeros, int anio)
        {
            this.placa = placa;
            this.matricula = matricula;
            //this.modelo = modelo;
            this.tipo_vehiculo = Tipo_V;
            this.num_pasajero = num_pasajeros;
            this.anio = anio;
           
        }
        //public void Registrar_Vehiculo(string placa, string matricula, string modelo, string Tipo_V, int num_pasajeros, int anio)
        public void Registrar_Vehiculo(string placa, string matricula, string Tipo_V, int num_pasajeros, int anio)
        {

            //conn.ingresardatos("insert into VEHICULO values ('"+Tipo_V+"','"+placa+"','"+matricula+"',"+num_pasajeros+","+anio+",'"+modelo+"')");
            conn.ingresardatos("insert into VEHICULO values ('" + Tipo_V + "','" + placa + "','" + matricula + "'," + num_pasajeros + "," + anio + ")");

        }

        public string Buscar_Vehiculo(string placa)
        {
           // conn.Buscar(placa);
            return "";
        }
        public void Actualizar_Vehiculo(string cadena)
        {
            conn.query(cadena);
        }
        public int Getid_vehiculo()
        {
            return id_vehiculo;
        }
        public void Setid_vehiculo(int id_vehiculo)
        {
            this.id_vehiculo = id_vehiculo;

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
            this.matricula = matricula;

        }
        public int Getanio()
        {
            return anio;
        }
        public void Setmodelo(int anio)
        {
            this.anio=anio;

        }
        public string Gettipo_vehiculo()
        {
            return tipo_vehiculo;
        }
        public void Settipo_vehiculo(string tipo_vehiculo)
        {
            this.tipo_vehiculo = tipo_vehiculo;

        }
        public int Getnum_pasajero()
        {
            return num_pasajero;
        }
        public void Setnum_pasajero(int num_pasajero)
        {
            this.num_pasajero = num_pasajero;

        }

    }
}
