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
    public partial class Incidencia : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        int id = 0;
        string placa;
        string timeP;
        string hora;
        string descripcion;

        public int getid() { return this.id; }
        public void setid(int id) { this.id = id; }
        public string getplaca() { return this.placa; }
        public void setplaca(string placa) { this.placa = placa; }
        public string gettimeP() { return this.timeP; }
        public void settimeP(string timeP) { this.timeP = timeP; }
        public string gethora() { return this.hora; }
        public void sethora(string hora) { this.hora = hora; }
        public string getdescripcion() { return this.descripcion; }
        public void setdescripcion(string descripcion) { this.descripcion = descripcion; }
        public Incidencia()
        {
            InitializeComponent();
        }

        private void incidenciaIDTextBox_TextChanged(object sender, EventArgs e)
        {
            string n = incidenciaID.Text;
            id = int.Parse(n);
        }

        private void Incidencia_Load(object sender, EventArgs e)
        {
            con.llenarItems(PLACAVEHICULO);
        }

        private void PLACAVEHICULO_SelectedIndexChanged(object sender, EventArgs e)
        {
            //placa = Convert.ToString(PLACAVEHICULO.SelectedValue);
            //placa = Convert.ToString(PLACAVEHICULO.SelectedText);
        }

        private void horaIncidencia_TextChanged(object sender, EventArgs e)
        {
            hora = horaIncidencia.Text;
        }

        private void fechaIncidencia_ValueChanged(object sender, EventArgs e)
        {
            timeP = fechaIncidencia.Text;
        }

        private void descripcionD_TextChanged(object sender, EventArgs e)
        {
            descripcion = descripcionD.Text;
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            placa = Convert.ToString(this.PLACAVEHICULO.Text);
            try{
                con.query("insert into incidencia values('" + id + "','" + hora + "','" + timeP + "','" + descripcion + "','" + placa + "');");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos no válidos" + ex.ToString());
            }
            
            MessageBox.Show("Registro ingresado con exito");
        }
    }
}
