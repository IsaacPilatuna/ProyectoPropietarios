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
    public partial class FrmReporteViajes : Form
    {
        public FrmReporteViajes()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT distinct reservaaprobada.idSolicitante, usuarios.nombre FROM dbo.reservaaprobada,dbo.usuarios where dbo.reservaaprobada.idsolicitante=dbo.usuarios.idusuario", conn);
                reader = comando.ExecuteReader();
               
                comboBoxSolicitantes.DisplayMember = "Text";
                comboBoxSolicitantes.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxSolicitantes.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxSolicitantes.SelectedIndex = 0;
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
                comboBoxSolicitantes.Enabled = true;
            }
            else
            {
                comboBoxSolicitantes.Enabled = false;
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
            String consulta = "SELECT solicitudreserva.lugar, reservaaprobada.fechasalida, reservaaprobada.fecharetorno, usuarios.nombre, reservaaprobada.numeropersonas FROM reservaaprobada join solicitudreserva on reservaaprobada.idreservaaprob = solicitudreserva.idsolicitudreserva JOIN usuarios on solicitudreserva.idusuario = usuarios.idusuario";
            if (checkBoxSolicitante.Checked)
            {
                int idSolicitante = (int)comboBoxSolicitantes.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxSolicitantes.SelectedItem);
                consulta += " WHERE usuarios.idusuario =" + idSolicitante;
                if (checkBoxFecha.Checked)
                {
                    consulta += " AND reservaaprobada.fechasalida BETWEEN '" + dateTimePickerDesde.Value.ToShortDateString() + "' AND '" + dateTimePickerHasta.Value.ToShortDateString() + "' ";
                }
            }
            else
            {
                if (checkBoxFecha.Checked)
                {
                    consulta += " WHERE reservaaprobada.fechasalida BETWEEN '" + dateTimePickerDesde.Value.ToShortDateString() + "' AND '" + dateTimePickerHasta.Value.ToShortDateString() + "' ";
                }
            }

            consulta += " order BY usuarios.nombre, reservaaprobada.fechasalida";
            DataSetViajes dsViajes = new DataSetViajes();
            SqlConnection cn = new SqlConnection(new Conexion().stringConexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            da.Fill(dsViajes, dsViajes.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("DataSetViajes", dsViajes.Tables[0]);
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
