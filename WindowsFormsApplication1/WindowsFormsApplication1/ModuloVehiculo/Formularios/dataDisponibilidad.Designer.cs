namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class dataDisponibilidad
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
            this.disponibilidadVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disponibilidadVehiculoTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.DisponibilidadVehiculoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.disponibilidadVehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disponibilidadVehiculoBindingSource
            // 
            this.disponibilidadVehiculoBindingSource.DataMember = "DisponibilidadVehiculo";
            this.disponibilidadVehiculoBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // disponibilidadVehiculoTableAdapter
            // 
            this.disponibilidadVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calificacion_ServicioTableAdapter = null;
            this.tableAdapterManager.CargosTableAdapter = null;
            this.tableAdapterManager.CHOFERTableAdapter = null;
            this.tableAdapterManager.CuentaTableAdapter = null;
            this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = this.disponibilidadVehiculoTableAdapter;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.MotivoViajeTableAdapter = null;
            this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // disponibilidadVehiculoDataGridView
            // 
            this.disponibilidadVehiculoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disponibilidadVehiculoDataGridView.AutoGenerateColumns = false;
            this.disponibilidadVehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disponibilidadVehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.disponibilidadVehiculoDataGridView.DataSource = this.disponibilidadVehiculoBindingSource;
            this.disponibilidadVehiculoDataGridView.Location = new System.Drawing.Point(39, 58);
            this.disponibilidadVehiculoDataGridView.Name = "disponibilidadVehiculoDataGridView";
            this.disponibilidadVehiculoDataGridView.Size = new System.Drawing.Size(638, 218);
            this.disponibilidadVehiculoDataGridView.TabIndex = 1;
            this.disponibilidadVehiculoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.disponibilidadVehiculoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDisponibilidadVehiculo";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDisponibilidadVehiculo";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_inicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_inicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_fin";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_fin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado_vehiculo";
            this.dataGridViewTextBoxColumn6.HeaderText = "estado_vehiculo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.disponibilidadVehiculoDataGridView);
            this.Name = "dataDisponibilidad";
            this.Text = "Lista de Disponibilidad de Vehiculos";
            this.Load += new System.EventHandler(this.dataDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource disponibilidadVehiculoBindingSource;
        private DataSetVehiculoTableAdapters.DisponibilidadVehiculoTableAdapter disponibilidadVehiculoTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView disponibilidadVehiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}