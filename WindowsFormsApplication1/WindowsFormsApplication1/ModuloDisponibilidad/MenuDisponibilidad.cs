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
    public partial class MenuDisponibilidad : Form
    {
        public MenuDisponibilidad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuDisponibilidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(1);
            calendario.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
