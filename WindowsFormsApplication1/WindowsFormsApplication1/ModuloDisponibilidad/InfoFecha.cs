using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloDisponibilidad
{
    public partial class InfoFecha : Form
    {
        DateTime aux = new DateTime();

        String aConsultar = "Select IDCHOFER AS \"CHOFER\", IDVEHICULO AS \"VEHICULO\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE RETORNO\", ESTADOSOLICITUD AS \"ESTADO DE LA SOLICITUD\"  from RESERVAAPROBADA";//para pasar los datos al data grid view
        
        public InfoFecha()
        {
            InitializeComponent();
        }
        public InfoFecha(String textoFecha,DateTime date)
        {
            InitializeComponent();
            this.label1.Text = textoFecha+".";
            this.aux = date;
            String a = convertirFecha(date);
            

           aConsultar += " where cast (FECHASALIDA as date)<='"+a+"' and cast (FECHARETORNO as date) >= '"+a+"'";

            Consulta consulta = new Consulta();
            consulta.cargarDatos(aConsultar, this.dataGridView1);
         
        }
        public String convertirFecha(DateTime date) {
            String año = Convert.ToString(date.Year);
            String mes = Convert.ToString(date.Month);
            String dia = Convert.ToString(date.Day);
            String fecha = año + "-" + mes + "-" + dia;
           

            return fecha;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoFecha_Load(object sender, EventArgs e)
        {
            
        }
    }
}
