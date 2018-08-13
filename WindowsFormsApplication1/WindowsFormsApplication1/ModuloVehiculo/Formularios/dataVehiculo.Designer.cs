namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class dataVehiculo
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
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULOTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.VEHICULOTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.vEHICULODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            this.vEHICULOBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // vEHICULOTableAdapter
            // 
            this.vEHICULOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULODataGridView
            // 
            this.vEHICULODataGridView.AutoGenerateColumns = false;
            this.vEHICULODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vEHICULODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vEHICULODataGridView.DataSource = this.vEHICULOBindingSource;
            this.vEHICULODataGridView.Location = new System.Drawing.Point(29, 60);
            this.vEHICULODataGridView.Name = "vEHICULODataGridView";
            this.vEHICULODataGridView.Size = new System.Drawing.Size(564, 220);
            this.vEHICULODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDVEHICULO";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDVEHICULO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPOVEHICULO";
            this.dataGridViewTextBoxColumn2.HeaderText = "TIPOVEHICULO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PLACAVEHICULO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PLACAVEHICULO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn4.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numeroPasajeros";
            this.dataGridViewTextBoxColumn5.HeaderText = "numeroPasajeros";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "anioVehiculo";
            this.dataGridViewTextBoxColumn6.HeaderText = "anioVehiculo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vEHICULODataGridView);
            this.Name = "dataVehiculo";
            this.Text = "Lista de Vehiculos";
            this.Load += new System.EventHandler(this.dataVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private DataSetVehiculoTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vEHICULODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}