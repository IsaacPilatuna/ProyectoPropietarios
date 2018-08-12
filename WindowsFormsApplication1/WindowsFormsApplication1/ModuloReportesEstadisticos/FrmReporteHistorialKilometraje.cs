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
    public partial class FrmReporteHistorialKilometraje : Form
    {
        public FrmReporteHistorialKilometraje()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection  conn = new SqlConnection(new Conexion().stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT idVehiculo, PLACAVEHICULO FROM dbo.vehiculo", conn);
                reader = comando.ExecuteReader();
                comboBoxPlacas.DisplayMember = "Text";
                comboBoxPlacas.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxPlacas.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxPlacas.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void FrmReporteHistorialKilometraje_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT fecha, kilometraje, vehiculo.idVehiculo, dbo.vehiculo.PLACAVEHICULO FROM HistorialKilometraje join vehiculo on HistorialKilometraje.idVehiculo = vehiculo.idvehiculo";
            if (checkBoxPlaca.Checked)
            {
                int idVehiculo = (int) comboBoxPlacas.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxPlacas.SelectedItem);
                consulta += " WHERE vehiculo.idVehiculo ="+ idVehiculo;
                if (checkBoxFecha.Checked)
                {
                    consulta += " AND fecha BETWEEN '"+ dateTimePickerDesde.Value.ToShortDateString() + "' AND '"+dateTimePickerHasta.Value.ToShortDateString()+"' ";
                }
            }
            else
            {
                if (checkBoxFecha.Checked)
                {
                    consulta += " WHERE fecha BETWEEN '" + dateTimePickerDesde.Value.ToShortDateString() + "' AND '" + dateTimePickerHasta.Value.ToShortDateString() + "' ";
                }
            }

            consulta += " order BY vehiculo.idVehiculo, kilometraje";
            DataSetHistorialKilometraje dsKilometraje = new DataSetHistorialKilometraje();
            SqlConnection cn = new SqlConnection(new Conexion().stringConexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            da.Fill(dsKilometraje, dsKilometraje.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("DataSetHistorialKilometraje", dsKilometraje.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlaca.Checked == true)
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
    }
}
