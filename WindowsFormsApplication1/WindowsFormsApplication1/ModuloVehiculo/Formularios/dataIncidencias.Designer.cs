namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class dataIncidencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.incidenciaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciaVehiculoTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.IncidenciaVehiculoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.incidenciaVehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciaVehiculoBindingSource
            // 
            this.incidenciaVehiculoBindingSource.DataMember = "IncidenciaVehiculo";
            this.incidenciaVehiculoBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // incidenciaVehiculoTableAdapter
            // 
            this.incidenciaVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calificacion_ServicioTableAdapter = null;
            this.tableAdapterManager.CargosTableAdapter = null;
            this.tableAdapterManager.CHOFERTableAdapter = null;
            this.tableAdapterManager.CuentaTableAdapter = null;
            this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.IncidenciaVehiculoTableAdapter = this.incidenciaVehiculoTableAdapter;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.MotivoViajeTableAdapter = null;
            this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // incidenciaVehiculoDataGridView
            // 
            this.incidenciaVehiculoDataGridView.AutoGenerateColumns = false;
            this.incidenciaVehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenciaVehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.incidenciaVehiculoDataGridView.DataSource = this.incidenciaVehiculoBindingSource;
            this.incidenciaVehiculoDataGridView.Location = new System.Drawing.Point(63, 79);
            this.incidenciaVehiculoDataGridView.Name = "incidenciaVehiculoDataGridView";
            this.incidenciaVehiculoDataGridView.Size = new System.Drawing.Size(530, 220);
            this.incidenciaVehiculoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idIncidenciaVehiculo";
            this.dataGridViewTextBoxColumn1.HeaderText = "idIncidenciaVehiculo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDVEHICULO";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDVEHICULO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn4.HeaderText = "hora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidenciaVehiculoDataGridView);
            this.Name = "dataIncidencias";
            this.Text = "Lista de Incidencias";
            this.Load += new System.EventHandler(this.dataIncidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource incidenciaVehiculoBindingSource;
        private DataSetVehiculoTableAdapters.IncidenciaVehiculoTableAdapter incidenciaVehiculoTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView incidenciaVehiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}