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


        String aConsultar = "Select V.TIPOVEHICULO AS \"TIPO DE VEHICULO\", V.PLACAVEHICULO AS \"PLACA\", CH.NOMBRECOMPLETO AS \"NOMBRES DEL CHOFER\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE REGRESO\" From RESERVAAPROBADA RA, CHOFER CH, VEHICULO V where CH.IDCHOFER = RA.IDCHOFER AND V.IDVEHICULO = RA.IDVEHICULO AND V.TIPOVEHICULO='AUTO'";
        //String aConsultar = "Select IDCHOFER AS \"CHOFER\", IDVEHICULO AS \"VEHICULO\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE RETORNO\", ESTADOSOLICITUD AS \"ESTADO DE LA SOLICITUD\"  from RESERVAAPROBADA";//para pasar los datos al data grid view

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
                this.aConsultar = "Select V.TIPOVEHICULO AS \"TIPO DE VEHICULO\", V.PLACAVEHICULO AS \"PLACA\", CH.NOMBRECOMPLETO AS \"NOMBRES DEL CHOFER\", FECHASALIDA AS \"FECHA DE SALIDA\", FECHARETORNO AS \"FECHA DE REGRESO\" From RESERVAAPROBADA RA, CHOFER CH, VEHICULO V where CH.IDCHOFER = RA.IDCHOFER AND V.IDVEHICULO = RA.IDVEHICULO AND V.TIPOVEHICULO='BUS'";
                ;//para pasar los datos al data grid view


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
          //  dataGridView1.DataSource = fechas;

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
           
            mostrarInformación(panel60);
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

            panel.BackColor = System.Drawing.Color.FromArgb(3,2,65);





        }
        public void desmarcarPanel(Panel panel) {
            panel.BackColor = marcar;

        }
        public void mostrarInfo(String textoFecha, DateTime date) {

            InfoFecha a = new InfoFecha(textoFecha,date );
            a.Show();
        }

        public void mostrarInformación(Panel panel) {
            DateTime aux = primerDiaSemana(monthCalendar1);
            

            tableLayoutPanel1.GetPositionFromControl(panel);
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetPositionFromControl(panel);
            String textoFecha = tableLayoutPanel1.GetControlFromPosition(pos.Column, 0).Text;
            mostrarInfo(textoFecha, aux.AddDays(pos.Column-1));




        }



        private void panel76_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel60_MouseHover(object sender, EventArgs e)
        {
            marcarPanel(panel60);
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            
            
        }
        

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel61_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel68_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel68);
        }

        private void panel75_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel75);
        }

        private void panel91_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel91);
        }

        private void panel92_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel92);
        }

        private void panel16_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel16);
        }

        private void panel120_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel120);
        }

        private void panel61_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel60);
        }

        private void panel80_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel76_DoubleClick(object sender, EventArgs e)
        {
            mostrarInformación(panel76);
        }

        private void panel119_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel61_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel61_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel60);
        }

        private void panel61_MouseEnter_1(object sender, EventArgs e)
        {
            marcarPanel(panel61);
        }

        private void panel62_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel62);
        }

        private void panel63_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel63);
        }

        private void panel61_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel61);
        }

        private void panel62_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel62);
        }

        private void panel63_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel63);
        }

        private void panel64_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel64);
        }

        private void panel119_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel119);
        }

        private void panel118_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel118);
        }

        private void panel117_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel117);
        }

        private void p1_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p1);
        }

        private void p8_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p8);
        }

        private void p15_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p15);
        }

        private void p22_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p22);
        }

        private void p29_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p29);
        }

        private void p36_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p36);
        }

        private void p43_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p43);
        }

        private void p50_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel50);
        }

        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            marcarPanel(panel3);
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel7);
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel13);
        }

        private void panel19_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel9);
        }

        private void panel22_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel22);
        }

        private void panel23_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel23);
        }

        private void panel25_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel25);
        }

        private void panel109_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel109);
        }

        private void panel119_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel119);
        }

        private void panel118_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel118);
        }

        private void panel117_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel117);
        }

        private void p1_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p1);
        }

        private void p8_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p8);
        }

        private void p15_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p15);
        }

        private void p22_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p22);
        }

        private void p29_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p29);
            
        }

        private void p36_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p36);
        }

        private void p43_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p43);
        }

        private void p50_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p50);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel3);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel17);
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel13);
        }

        private void panel19_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel19);
        }

        private void panel22_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p22);
        }

        private void panel23_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p22);
        }

        private void panel25_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel25);
        }

        private void panel109_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel109);
        }

        private void panel68_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel68);
        }

        private void panel80_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel80);
        }

        private void panel70_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel70);
        }

        private void panel108_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel108);
        }

        private void panel71_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel71);
        }

        private void panel72_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel72);
        }

        private void panel73_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel73);
        }

        private void panel74_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void p2_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p2);
        }

        private void p9_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p9);
        }

        private void p16_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p16);
        }

        private void p23_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p23);
        }

        private void p30_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p30);
        }

        private void p37_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p37);
        }

        private void p44_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p44);
        }

        private void panel75_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel75);
        }

        private void panel76_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel76);
        }

        private void panel77_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel77);
        }

        private void panel78_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel78);
        }

        private void panel79_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel79);
        }

        private void panel81_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel81);
        }

        private void panel82_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel82);
        }

        private void panel83_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel83);
        }

        private void p3_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p3);
        }

        private void p10_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p10);
        }

        private void p17_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p17);
        }

        private void p24_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p24);
        }

        private void p31_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p31);
        }

        private void p38_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p38);
        }

        private void p45_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p45);
        }

        private void panel68_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel68);
        }

        private void panel91_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel91);
        }

        private void panel92_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel92);
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel16);
        }

        private void panel120_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel120);
        }

        private void panel123_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel123);
        }

        private void panel124_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel125_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel125);
        }

        private void panel124_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel124);
        }

        private void panel126_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel126);
        }

        private void panel127_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel127);
        }

        private void panel128_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel128_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel128);
        }

        private void panel129_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel130_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel130_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel130);
        }

        private void panel129_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel129);
        }

        private void p11_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p11);
        }

        private void p18_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p18);
        }

        private void p25_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p25);
        }

        private void p32_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p32);
        }

        private void p39_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p39);
        }

        private void p46_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p46);
        }

        private void panel93_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel93);
        }

        private void panel94_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel94);
        }

        private void panel95_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel95);
        }

        private void panel96_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel96);
        }

        private void panel97_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel97_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel97);
        }

        private void panel98_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel98);
        }

        private void panel99_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel99);
        }

        private void p5_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p5);
        }

        private void p12_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p12);
        }

        private void p19_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p19);
        }

        private void p26_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p26);
        }

        private void p33_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p33);
        }

        private void p40_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p40);
        }

        private void p47_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p47);
        }

        private void panel69_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel69);
        }

        private void panel59_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel59);
        }

        private void panel100_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel100);
        }

        private void panel110_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel110);
        }

        private void panel101_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel101);
        }

        private void panel111_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel111);
        }

        private void panel102_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel102);
        }

        private void panel112_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel112);
        }

        private void panel104_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel104);
        }

        private void panel67_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel67);
        }

        private void panel105_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel105);
        }

        private void panel66_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel66);
        }

        private void panel106_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel106);
        }

        private void panel65_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel65);
        }

        private void panel107_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel107);
        }

        private void p7_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p7);
        }

        private void p13_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p13);
        }

        private void p14_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p14);
        }

        private void p20_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p20);
        }

        private void p21_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p21);
        }

        private void p27_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p27);
        }

        private void p28_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p28);
        }

        private void p34_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p34);
        }

        private void p35_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p35);
        }

        private void p41_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p41);
        }

        private void p42_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p42);
        }

        private void p48_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p48);
        }

        private void p49_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(p49);
        }

        private void panel80_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel80);
        }

        private void panel70_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel70);
        }

        private void panel108_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel108);
        }

        private void panel71_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel71);
        }

        private void panel72_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel72);
        }

        private void panel73_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel73);
        }

        private void panel74_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel74);
        }

        private void panel74_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel74);
        }

        private void p2_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p2);
        }

        private void p9_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p9);
        }

        private void p16_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p16);
        }

        private void p23_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p23);
        }

        private void p30_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p30);
        }

        private void p37_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p37);
        }

        private void p44_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p44);
        }

        private void panel75_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel75);
        }

        private void panel76_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel76);
        }

        private void panel77_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel77);
        }

        private void panel78_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel78);
        }

        private void panel79_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel79);
        }

        private void panel81_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel81);
        }

        private void panel82_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel82);
        }

        private void panel83_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel83);
        }

        private void p3_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p3);
        }

        private void p10_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p10);
        }

        private void p17_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p17);
        }

        private void p24_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p24);
        }

        private void p31_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p31);
        }

        private void p38_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p38);
        }

        private void p45_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p45);
        }

        private void panel91_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel91);
        }

        private void panel123_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel123);
        }

        private void panel124_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel124);
        }

        private void panel125_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel125);
        }

        private void panel126_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel126);
        }

        private void panel127_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel127);
        }

        private void panel128_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel128);
        }

        private void panel129_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel129);
        }

        private void panel130_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel130);
        }

        private void p11_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p11);
        }

        private void p18_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p18);
        }

        private void p25_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p25);
        }

        private void p32_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p32);
        }

        private void p39_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p39);
        }

        private void p46_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p46);
        }

        private void panel92_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel92);
        }

        private void panel93_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel93);
        }

        private void panel94_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel94);
        }

        private void panel95_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel95);
        }

        private void panel96_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel96_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel96);
        }

        private void panel97_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel97);
        }

        private void panel98_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel98);
        }

        private void panel99_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel99);
        }

        private void p5_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p5);
        }

        private void p12_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p12);
        }

        private void p19_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p19);
        }

        private void p26_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p26);
        }

        private void p33_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p33);
        }

        private void p40_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p40);
        }

        private void p47_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p47);
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel16);
        }

        private void panel120_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel120);
        }

        private void panel69_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel69);
        }

        private void panel59_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel59);
        }

        private void panel100_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel100);
        }

        private void panel110_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel110);
        }

        private void panel101_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel101);
        }

        private void panel111_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel111);
        }

        private void panel102_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel102);
        }

        private void panel112_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel112_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel112);
        }

        private void panel104_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel104);
        }

        private void panel67_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel67);
        }

        private void panel105_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel105);
        }

        private void panel66_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel66_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel66);
        }

        private void panel106_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel106);
        }

        private void panel65_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel65);
        }

        private void panel107_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(panel107);
        }

        private void p7_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p7);
        }

        private void p13_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p13);
        }

        private void p14_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p14);
        }

        private void p20_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p20);
        }

        private void p21_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p21);
        }

        private void p27_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p27);
        }

        private void p28_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p28);
        }

        private void p34_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p34);
        }

        private void p35_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p35);
        }

        private void p41_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p41);
        }

        private void p42_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p42);
        }

        private void p48_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p48);
        }

        private void p49_MouseLeave(object sender, EventArgs e)
        {
            desmarcarPanel(p49);
        }

        private void panel91_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel64_MouseEnter(object sender, EventArgs e)
        {
            marcarPanel(panel64);
        }
    }
}
    


