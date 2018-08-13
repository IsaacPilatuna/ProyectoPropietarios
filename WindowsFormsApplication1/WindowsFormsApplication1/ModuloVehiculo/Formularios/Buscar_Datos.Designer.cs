namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class Buscar_Datos
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
            System.Windows.Forms.Label pLACAVEHICULOLabel;
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULOTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.VEHICULOTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.pLACAVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            pLACAVEHICULOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pLACAVEHICULOLabel
            // 
            pLACAVEHICULOLabel.AutoSize = true;
            pLACAVEHICULOLabel.ForeColor = System.Drawing.Color.White;
            pLACAVEHICULOLabel.Location = new System.Drawing.Point(152, 61);
            pLACAVEHICULOLabel.Name = "pLACAVEHICULOLabel";
            pLACAVEHICULOLabel.Size = new System.Drawing.Size(119, 13);
            pLACAVEHICULOLabel.TabIndex = 3;
            pLACAVEHICULOLabel.Text = "PLACA DE VEHICULO:";
            pLACAVEHICULOLabel.Click += new System.EventHandler(this.pLACAVEHICULOLabel_Click);
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
            this.tableAdapterManager.SolicitudReservaTestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // pLACAVEHICULOComboBox
            // 
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOComboBox.FormattingEnabled = true;
            this.pLACAVEHICULOComboBox.Location = new System.Drawing.Point(277, 58);
            this.pLACAVEHICULOComboBox.Name = "pLACAVEHICULOComboBox";
            this.pLACAVEHICULOComboBox.Size = new System.Drawing.Size(151, 21);
            this.pLACAVEHICULOComboBox.TabIndex = 4;
            this.pLACAVEHICULOComboBox.SelectedIndexChanged += new System.EventHandler(this.pLACAVEHICULOComboBox_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(277, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscar_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(pLACAVEHICULOLabel);
            this.Controls.Add(this.pLACAVEHICULOComboBox);
            this.Name = "Buscar_Datos";
            this.Text = "Buscar Datos de Vehiculo";
            this.Load += new System.EventHandler(this.Buscar_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private DataSetVehiculoTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox pLACAVEHICULOComboBox;
        private System.Windows.Forms.Button btnBuscar;
    }
}