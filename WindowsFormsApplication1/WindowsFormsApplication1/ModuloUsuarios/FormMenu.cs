using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1


{
    public partial class FormMenu : Form
    {


        GestiónModulos fm1;
        String auxuser;




        public void iniciar(GestiónModulos fm)
        {
            fm1 = fm;
        }

        public FormMenu()
        {
            InitializeComponent();
            

        }

        public FormMenu(String user)
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
            auxuser = user;

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir del sistema?", "AVISO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {

            }
        }



        //Esta función permite mover el form desde un panel

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        int LX, LY, SW, SH;




        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //Para guardar la posicion del tamaño con el que inicia
            //Esto nos sirve luego para el restaurar.

            //LX = this.Location.X;
            //LY = this.Location.Y;
            //SW = this.Size.Width;
            //SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1040, 640);
            this.Location = new Point(50, 50);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 57)
            {
                MenuVertical.Width = 250;
            }
            else

                MenuVertical.Width = 57;
        }



        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    mostrarlogo();
        //}


        //private void mostrarlogo() {
        //    AbrirFormInPanel(new FormSello());
        //}

        //private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e) {
        //    mostrarlogo();
        //}

        //OPCION 2 CON PANELES
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;



        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Show();
            this.toolCerrar.SetToolTip(cerrarSesión, "Clic para cerrar sesión");
        }

        private void cerrarSesión_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar la sesión", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.Show();
            }
            else
            {

            }

        }

       
        // public void mostrarReportes(FormMenu frmMenu)
 

        private void btnForm_Click(object sender, EventArgs e)
        {
            fm1.mostrarFormularios(this);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnVehículos_Click_1(object sender, EventArgs e)
        {
            fm1.mostrarModvehiculo(this);
        }

        private void btnNotificaciones_Click_1(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar(auxuser, "select idusuario, idcargo from usuarios where email= '" + auxuser + "'");
            DataRow row = dtaux.Rows[0];
            string email = Convert.ToString(row["idusuario"]);
            string cargo = Convert.ToString(row["idcargo"]);

            if (cargo == "3")
            {
                fm1.mostrarNotificaciones(this);
                // solicitudesPendientes sol = new solicitudesPendientes(auxuser);
                //sol.ShowDialog();
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            fm1.mostrarFormReservas(this);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelprincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }





    }
}
