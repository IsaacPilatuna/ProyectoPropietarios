using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloReportesEstadisticos
{
    public partial class FrmMenuPrincipalReportes : Form
    {
        public FrmMenuPrincipalReportes()
        {
            InitializeComponent();
            FrmReporteServicio frmServicio = new FrmReporteServicio();
            frmServicio.TopLevel = false;
            frmServicio.FormBorderStyle = FormBorderStyle.None;
            frmServicio.Dock = DockStyle.Fill;
            tabControl1.TabPages[1].Controls.Add(frmServicio);
            frmServicio.Show();
            FrmReporteViajes frmViajes = new FrmReporteViajes();
            frmViajes.TopLevel = false;
            frmViajes.FormBorderStyle = FormBorderStyle.None;
            frmViajes.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(frmViajes);
            frmViajes.Show();
            FrmReporteVehiculos frmvehiculo = new FrmReporteVehiculos();
            frmvehiculo.TopLevel = false;
            frmvehiculo.FormBorderStyle = FormBorderStyle.None;
            frmvehiculo.Dock = DockStyle.Fill;
            tabControl1.TabPages[2].Controls.Add(frmvehiculo);
            frmvehiculo.Show();
        }
    }
}
