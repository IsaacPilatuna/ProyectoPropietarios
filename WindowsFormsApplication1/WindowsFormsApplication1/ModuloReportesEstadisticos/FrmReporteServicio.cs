using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloReportesEstadisticos
{
    public partial class FrmReporteServicio : Form
    {
        public FrmReporteServicio()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT distinct reservaaprobada.idChofer, chofer.nombrecompleto FROM dbo.reservaaprobada,dbo.chofer where dbo.reservaaprobada.idchofer=dbo.chofer.idchofer", conn);
                reader = comando.ExecuteReader();

                comboBoxChoferes.DisplayMember = "Text";
                comboBoxChoferes.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxChoferes.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxChoferes.SelectedIndex = 0;
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine(e.ToString());
            }
        }

        private void checkBoxSolicitante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSolicitante.Checked)
            {
                comboBoxChoferes.Enabled = true;
            }
            else
            {
                comboBoxChoferes.Enabled = false;
            }
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFecha.Checked == true)
            {
                dateTimePickerDesde.Enabled = true;
                dateTimePickerHasta.Enabled = true;
            }
            else
            {
                dateTimePickerDesde.Enabled = false;
                dateTimePickerHasta.Enabled = false;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            String consulta = "  select puntualSalida, limpieza, puntualDestino, puntualRetorno, nombrecompleto from calificacion_servicio inner join reservaaprobada on calificacion_servicio.idReservaAprob = reservaaprobada.idReservaAprob inner join chofer on chofer.IDCHOFER = RESERVAAPROBADA.IDCHOFER";
            if (checkBoxSolicitante.Checked)
            {
                int idChofer = (int)comboBoxChoferes.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxChoferes.SelectedItem);
                consulta += " WHERE chofer.idchofer =" + idChofer;
                if (checkBoxFecha.Checked)
                {
                    consulta += " AND reservaaprobada.fechasalida BETWEEN '" + dateTimePickerDesde.Value.Date.ToString("dd/MM/yyyy") + "' AND '" + dateTimePickerHasta.Value.Date.ToString("dd/MM/yyyy") + "' ";
                }
            }
            else
            {
                if (checkBoxFecha.Checked)
                {
                    consulta += " WHERE reservaaprobada.fechasalida BETWEEN '" + dateTimePickerDesde.Value.Date.ToString("dd/MM/yyyy") + "' AND '" + dateTimePickerHasta.Value.Date.ToString("dd/MM/yyyy") + "' ";
                }
            }

            consulta += " order BY chofer.nombrecompleto";
            SqlConnection cn = new SqlConnection(new Conexion().stringConexion);
            cn.Open();
            SqlCommand comando = new SqlCommand(consulta, cn);
            SqlDataReader reader = comando.ExecuteReader();
            DataSetServicio dsServicio = new DataSetServicio();
            dsServicio.Tables[0].Load(reader);
            ReportDataSource rds = new ReportDataSource("DataSetServicio", dsServicio.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void FrmReporteViajes_Load(object sender, EventArgs e)
        {

        }
    }
}
