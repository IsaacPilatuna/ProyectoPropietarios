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
    public partial class FrmReporteVehiculos : Form
    {
        public FrmReporteVehiculos()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT distinct dbo.mantenimiento.idVehiculo, dbo.vehiculo.PLACAVEHICULO FROM dbo.mantenimiento inner join dbo.vehiculo on dbo.mantenimiento.idVehiculo = dbo.vehiculo.idvehiculo", conn);
                reader = comando.ExecuteReader();

                comboBoxPlacas.DisplayMember = "Text";
                comboBoxPlacas.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxPlacas.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxPlacas.SelectedIndex = 0;
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
                comboBoxPlacas.Enabled = true;
            }
            else
            {
                comboBoxPlacas.Enabled = false;
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
            String consulta = "select mantenimiento.fecha_mantenimiento, mantenimiento.kilometraje, VEHICULO.PLACAVEHICULO from Mantenimiento inner join VEHICULO on Mantenimiento.idVehiculo = Vehiculo.idVehiculo";
            if (checkBoxSolicitante.Checked)
            {
                int idvehiculo = (int)comboBoxPlacas.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxPlacas.SelectedItem);
                consulta += " WHERE vehiculo.idvehiculo =" + idvehiculo;
                if (checkBoxFecha.Checked)
                {
                    consulta += " AND mantenimiento.fecha_mantenimiento BETWEEN '" + dateTimePickerDesde.Value.Date.ToString("dd/MM/yyyy") + "' AND '" + dateTimePickerHasta.Value.Date.ToString("dd/MM/yyyy") + "' ";
                }
            }
            else
            {
                if (checkBoxFecha.Checked)
                {
                    consulta += " WHERE mantenimiento.fecha_mantenimiento BETWEEN '" + dateTimePickerDesde.Value.Date.ToString("dd/MM/yyyy") + "' AND '" + dateTimePickerHasta.Value.Date.ToString("dd/MM/yyyy") + "' ";
                }
            }

            consulta += " order BY VEHICULO.PLACAVEHICULO, mantenimiento.kilometraje";
            SqlConnection cn = new SqlConnection(new Conexion().stringConexion);
            cn.Open();
            SqlCommand comando = new SqlCommand(consulta, cn);
            SqlDataReader reader = comando.ExecuteReader();
            DataSetHistorialKilometraje dsKilometraje = new DataSetHistorialKilometraje();
            dsKilometraje.Tables[0].Load(reader);
            reader = comando.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string fecha = dsKilometraje.Tables[0].Rows[i]["fecha_mantenimiento"].ToString();
                fecha = fecha.Split()[0];
                dsKilometraje.Tables[0].Rows[i].SetField("fecha_mantenimiento", fecha);
                i++;

            }

            ReportDataSource rds = new ReportDataSource("DataSetHistorialKilometraje", dsKilometraje.Tables[0]);
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
