using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    public partial class Kilometraje : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        int id = 0;
        int kilo = 0;
        int idVehiculo=0;
        string  timeP;
        public Kilometraje()
        {
            InitializeComponent();
        }



        private void Kilometraje_Load(object sender, EventArgs e)
        {
            con.llenarItemsID(CBPlaca);
            //placa = CBPlaca.SelectedValue.ToString();
        }

        private void idHistorial_TextChanged(object sender, EventArgs e)
        {
            string n = idHistorial.Text;
            id = Int32.Parse(n);
        }

        private void time_ValueChanged(object sender, EventArgs e)
        {
            timeP = time.Text;
        }

        private void textkilometraje_TextChanged(object sender, EventArgs e)
        {
            string n = textkilometraje.Text;
            kilo= Int32.Parse(n);
        }

        public int getid() { return this.id; }
        public void setid(int id) { this.id = id; }
        public int getplaca() { return this.idVehiculo; }
        public void setplaca(int idVehiculo) { this.idVehiculo = idVehiculo; }
        public float getkilo() { return this.kilo; }
        public void setkilo(int kilo) { this.kilo = kilo; }
        public string gettimeP() { return this.timeP; }
        public void settimeP(string timeP) { this.timeP = timeP; }
        private void CBPlaca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string placa = Convert.ToString(CBPlaca.Text);
            idVehiculo = Int32.Parse(placa);
            //con.query("insert into HistorialKilometraje ('','','') values('" +id + "','" +timeP + "','" + kilo + "','" + idVehiculo + "');");
            con.query("insert into HistorialKilometraje (fecha,kilometraje,idVehiculo) values('" + timeP + "','" + kilo + "','" + idVehiculo + "');");
            MessageBox.Show("Registro ingresado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
