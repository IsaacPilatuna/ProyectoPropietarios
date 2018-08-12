using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1.ModuloDisponibilidad
{
    public partial class Calendario : Form
    {
        public Panel marcador = new Panel();
        Color marcar = new Color();


        //String aConsultar ="Select V.TIPOVEHICULO AS \"TIPO DE VEHICULO\", V.PLACAVEHICULO AS \"PLACA\", CH.NOMBRECHOFER+CH.APELLIDOCHOFER AS \"NOMBRES DEL CHOFER\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE REGRESO\" From RESERVAAPROBADA RA, CHOFER CH, VEHICULO V where CH.IDCHOFER = RA.IDCHOFER AND V.IDVEHICULO = RA.IDVEHICULO";
        String aConsultar = "Select IDCHOFER AS \"CHOFER\", IDVEHICULO AS \"VEHICULO\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE RETORNO\", ESTADOSOLICITUD AS \"ESTADO DE LA SOLICITUD\"  from RESERVAAPROBADA";//para pasar los datos al data grid view

        String fechasConsultadas = "select FECHASALIDA as f_i, FECHARETORNO as f_f FROM RESERVAAPROBADA";


        public Calendario()
        {
            InitializeComponent();
            // this.BackColor = Color.Black;
            int dis_a = 0;
            this.Size = new Size(1100, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            // tableLayoutPanel1.MaximumSize = new Size(tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            
            tableLayoutPanel1.AutoScroll = true;
        }
        public Calendario(int tipo) {
            if (tipo == 1) {
                this.aConsultar ="Select IDCHOFER AS \"CHOFERRR\", IDVEHICULO AS \"VEHICULO\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE RETORNO\", ESTADOSOLICITUD AS \"ESTADO DE LA SOLICITUD\"  from RESERVAAPROBADA";//para pasar los datos al data grid view


            }
            InitializeComponent();
            // this.BackColor = Color.Black;
            int dis_a = 0;
            this.Size = new Size(1100, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            // tableLayoutPanel1.MaximumSize = new Size(tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            monthCalendar1.TitleBackColor = Color.Blue;
            monthCalendar1.TrailingForeColor = Color.Red;
            monthCalendar1.TitleForeColor = Color.Yellow;
            tableLayoutPanel1.AutoScroll = true;

        }

        private void Calendario_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            tableLayoutPanel1.BackColor = Color.White;
            despintar();
            DateTime a = primerDiaSemana(monthCalendar1);
            llenarDias(a);
            //textBox2.Text = "primer dia " + a;

            //textBox1.Text = "Semana del:" + monthCalendar1.SelectionRange.Start;
            consultarReserva();

            //pruebas de manejo de la fecha





        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Date Selected :" + (int)monthCalendar1.SelectionRange.Start.DayOfWeek;
            /*  monthCalendar1.SelectionStart.Date.AddDays(1 - (monthCalendar1.SelectionStart.Date.DayOfWeek));
              'Último día de la semana
               MonthCalendar.SelectionStart.Date.AddDays(7 - (MonthCalendar.SelectionStart.Date.DayOfWeek))*/
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void label20_Click(object sender, EventArgs e)
        {

        }



        private void label25_Click(object sender, EventArgs e)
        {

        }
        public DateTime primerDiaSemana(MonthCalendar m) {
            DateTime f_select = m.SelectionRange.Start;
            int d_select = (int)m.SelectionRange.Start.DayOfWeek;


            if (d_select == 0)
            {
                DateTime a = f_select.AddDays(-6);
                return a;

            }
            else if (d_select != 0)
            {

                DateTime a = f_select.AddDays(1 - (int)f_select.DayOfWeek);
                return a;

            }

            return f_select;
        }

        

        public void consultarReserva()
        {
            
            Consulta consulta = new Consulta();

            consulta.cargarDatos(aConsultar, dataGridView1);
            DataTable fechas = consulta.tablaConsulta(fechasConsultadas);
           DataTable fueraDeRango = new DataTable();
           fueraDeRango.Columns.Add("f_i",typeof(DateTime));
           fueraDeRango.Columns.Add("f_f", typeof(DateTime));

            DateTime f_i = new DateTime();
            DateTime f_f = new DateTime();

            for (int i = 0; i < fechas.Rows.Count; i++)
            {
                f_i = Convert.ToDateTime(fechas.Rows[i]["f_i"]);
                f_f = Convert.ToDateTime(fechas.Rows[i]["f_f"]);
              FueraDeRango(f_i, f_f,fueraDeRango);
                pintar(f_i, f_f);
               pintarFechasFueraDeRango(fueraDeRango );
               
            }

            

            // textBox4.Text = Convert.ToString(f_i.TimeOfDay);
            //dataGridView1.DataSource = fechas;

        }

        public void FueraDeRango(DateTime f_i, DateTime f_f, DataTable fueraDeRangos) {

            DataRow row = fueraDeRangos.NewRow();
            int borde=0;
            int i = 0;
            DateTime aux=f_i.Date;
            borde = NumeroDia(Convert.ToInt32(f_i.DayOfWeek));
            if(f_i.Date < f_f.Date) {

                while (aux<f_f.Date && borde <=6) {
                    borde++;
                    i++;
                    aux.AddDays(i);
                }
                if(borde > 6)
                {
                    row["f_i"] = f_i;

                    row["f_f"] = f_f;
                    fueraDeRangos.Rows.Add(row);
                }




            }


        }
        public void pintarFechasFueraDeRango(DataTable fueraDeRango) {
            DateTime aux=primerDiaSemana(monthCalendar1);

           
                for (int j = 0; j<=6;++j) {
                for (int i = 0; i < fueraDeRango.Rows.Count;i++) {
                    if (RangoFecha(Convert.ToDateTime(fueraDeRango.Rows[i]["f_i"]), Convert.ToDateTime(fueraDeRango.Rows[i]["f_f"]), aux)) {
                        pintar(Convert.ToDateTime(fueraDeRango.Rows[i]["f_i"]), Convert.ToDateTime(fueraDeRango.Rows[i]["f_f"]));

                    }
                }
                aux.AddDays(j);
                }

            

           


        }

        public void pintar(DateTime f_i, DateTime f_f) {
            DateTime aux = primerDiaSemana(monthCalendar1);

            int h_i = Convert.ToInt32(f_i.Hour);
            int h_f = Convert.ToInt32(f_f.Hour);
            //textBox4.Text = Convert.ToString(f_i) + f_f;
            
                if (f_i.Date == f_f.Date)
                {//valida si la fecha de inicio es = a la de fin
                    for (int i = 0; i <= 6; i++)
                    {//contador para que auxiliar aumente
                        if (aux.AddDays(i) == f_i.Date)
                        {//valida que auxiliar sea igual a las fechas de inicio y fin(xq las dos son iguales)
                            //textBox5.Text = "Si es igual y estoy en la otra parte zorro";
                            for (int j = h_i; j < h_f; j++)
                            {
                                tableLayoutPanel1.GetControlFromPosition(i + 1, j+1).BackColor = Color.Orange;
                            }
                        }
                        else if (aux.AddDays(i) == f_i && aux.AddDays(i) < f_f)
                        {//valida que la fecha de inicio sea menor que la final

                        }
                    }
                }
            else if (f_i.Date < f_f.Date){
                for (int i = 0; i <= 6; i++)
                {
                    if (RangoFecha(f_i.Date, f_f.Date, aux.AddDays(i)) && aux.AddDays(i) == f_i.Date)
                    {
                        for (int j = h_i; j < 24; j++)
                        {
                            tableLayoutPanel1.GetControlFromPosition(i + 1, j + 1).BackColor = Color.Orange;
                        }

                    }
                    else if (RangoFecha(f_i.Date, f_f.Date, aux.AddDays(i)) && aux.AddDays(i) != f_i.Date && aux.AddDays(i) != f_f.Date)
                    {
                        for (int j = 0; j < 24; j++)
                        {
                            tableLayoutPanel1.GetControlFromPosition(i + 1, j + 1).BackColor = Color.Orange;
                        }

                    }
                
                    else if (RangoFecha(f_i.Date, f_f.Date, aux.AddDays(i)) && aux.AddDays(i) == f_f.Date)
                    {
                        for (int j = 0; j < h_f; j++)
                        {
                            tableLayoutPanel1.GetControlFromPosition(i + 1, j+1).BackColor = Color.Orange;
                        }

                    }



                }

                
            }



            

            /*
            
            DateTime aux = f_i;
             textBox4.Text = "detected"+aux;
             if (aux.DayOfWeek == 0)
             {
                 if(aux==f_i)
                 tableLayoutPanel1.GetControlFromPosition(7, hora - 7).BackColor = Color.Orange;
             }

                do
                {
                    if (f_i.DayOfWeek == 0)
                    {

                        tableLayoutPanel1.GetControlFromPosition(7, hora-7).BackColor = Color.Orange;
                    }
                    else if (f_i.DayOfWeek != 0) {

                        tableLayoutPanel1.GetControlFromPosition((int)f_i.DayOfWeek+1, hora).BackColor = Color.Orange;

                    }

                    aux= f_i.AddDays(1);


                } while (aux != f_f);
                if (f_f.DayOfWeek == 0)
                {
                    tableLayoutPanel1.GetControlFromPosition(7, hora-7).BackColor = Color.Orange;
                }
                else {

                    tableLayoutPanel1.GetControlFromPosition((int)f_f.DayOfWeek+1, hora-7).BackColor = Color.Orange;
                }
                */

        }

        public void despintar() {
            for (int i = 1; i <= 7; i++) {
                for (int j = 1; j <= 24; j++) {
                    tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.LimeGreen;
                }

            }
        }


        public Boolean RangoFecha(DateTime f_i,DateTime f_f, DateTime f_test){

            if (f_i <= f_test && f_test <= f_f)
            {
                return true;
            }
            else {

                return false;
            }
        }
            


            

        public int NumeroDia(int n){
            if (n == 0) { return 6; }
            else {
                return n - 1;
            }
        }
        public void llenarDias(DateTime dia)
        {
            // DateTime aux = dia.AddDays(1);

            lb_lunes.Text = "LUNES " + dia.Day + " DE " + MesEnDias(dia.Month);
            lb_martes.Text = "MARTES  " + dia.AddDays(1).Day + " DE " + MesEnDias(dia.AddDays(1).Month); 
            lb_miercoles.Text = "MIERCOLES " + dia.AddDays(2).Day + " DE " + MesEnDias(dia.AddDays(2).Month); 
            lb_jueves.Text = "JUEVES  " + dia.AddDays(3).Day + " DE " + MesEnDias(dia.AddDays(3).Month); 
            lb_viernes.Text = "VIERNES  " + dia.AddDays(4).Day + " DE " + MesEnDias(dia.AddDays(4).Month); 
            lb_sabado.Text = "SABADO  " + dia.AddDays(5).Day + " DE " + MesEnDias(dia.AddDays(5).Month); 
            lb_domingo.Text = "DOMINGO  " + dia.AddDays(6).Day + " DE " + MesEnDias(dia.AddDays(6).Month); 
        }
        public String MesEnDias(int m ) {
            if (m == 1)
                return "ENE";
            else if (m == 2)
                return "FEB";
            else if (m == 3)
                return "MAR";
            else if (m == 4)
                return "ABR";
            else if (m == 5)
                return "MAY";
            else if (m == 6)
                return "JUN";
            else if (m == 7)
                return "JUL";
            else if (m == 8)
                return "AGO";
            else if (m == 9)
                return "SEP";
            else if (m == 10)
                return "OCT";
            else if (m == 11)
                return "NOV";
            else if (m == 12)
                return "DIC";
            else return "MES FUERA DE RANG";
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void p8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p50_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel54_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel58_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel55_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p54_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p19_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void p12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p39_Paint(object sender, PaintEventArgs e)
        {

        }


        private void p46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p48_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel57_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel50_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel59_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel48_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel115_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel114_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel116_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel69_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel110_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void panel65_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario a = new Calendario();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void panel60_Paint(object sender, PaintEventArgs e)
        {
            
           
                
             
        }

        private void panel60_DoubleClick(object sender, EventArgs e)
        {
            InfoFecha a = new InfoFecha();
            a.Show();
        }

        private void panel84_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel60_MouseLeave(object sender, EventArgs e)
        {


            desmarcarPanel(panel60);
         
            
        }

        private void panel60_MouseEnter(object sender, EventArgs e)
        {

            marcarPanel(panel60);

        }
        public void marcarPanel(Panel panel) {


            marcar = panel60.BackColor;

            panel.BackColor = Color.Blue;





        }
        public void desmarcarPanel(Panel panel) {
            panel.BackColor = marcar;

        }

        private void panel76_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel60_MouseHover(object sender, EventArgs e)
        {
            marcarPanel(panel60);
        }
    }
}
    


