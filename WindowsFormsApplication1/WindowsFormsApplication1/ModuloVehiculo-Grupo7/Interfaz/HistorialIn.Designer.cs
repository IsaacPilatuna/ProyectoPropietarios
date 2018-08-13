namespace WindowsFormsApplication1.ModuloVehiculo_Grupo7.Interfaz
{
    partial class HistorialIn
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVEHICULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidenciaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAAPDataSet = new WindowsFormsApplication1.sistemaAAPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.incidenciaVehiculoTableAdapter = new WindowsFormsApplication1.sistemaAAPDataSetTableAdapters.IncidenciaVehiculoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(295, 407);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(142, 29);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HISTORIAL DE INCIDENCIAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.iDVEHICULODataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidenciaVehiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // idIncidenciaVehiculoDataGridViewTextBoxColumn
            // 
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn.DataPropertyName = "idIncidenciaVehiculo";
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn.HeaderText = "idIncidenciaVehiculo";
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn.Name = "idIncidenciaVehiculoDataGridViewTextBoxColumn";
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idIncidenciaVehiculoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDVEHICULODataGridViewTextBoxColumn
            // 
            this.iDVEHICULODataGridViewTextBoxColumn.DataPropertyName = "IDVEHICULO";
            this.iDVEHICULODataGridViewTextBoxColumn.HeaderText = "IDVEHICULO";
            this.iDVEHICULODataGridViewTextBoxColumn.Name = "iDVEHICULODataGridViewTextBoxColumn";
            this.iDVEHICULODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVEHICULODataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "HORA";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incidenciaVehiculoBindingSource
            // 
            this.incidenciaVehiculoBindingSource.DataMember = "IncidenciaVehiculo";
            this.incidenciaVehiculoBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // sistemaAAPDataSet
            // 
            this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Módulo De Vehiculo";
            // 
            // incidenciaVehiculoTableAdapter
            // 
            this.incidenciaVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // HistorialIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(752, 467);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HistorialIn";
            this.Text = "HistorialIn";
            this.Load += new System.EventHandler(this.HistorialIn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource incidenciaVehiculoBindingSource;
        private sistemaAAPDataSetTableAdapters.IncidenciaVehiculoTableAdapter incidenciaVehiculoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIncidenciaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVEHICULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}