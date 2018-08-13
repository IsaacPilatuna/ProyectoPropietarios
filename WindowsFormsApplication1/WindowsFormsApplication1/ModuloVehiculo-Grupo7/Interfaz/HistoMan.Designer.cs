namespace WindowsFormsApplication1.ModuloVehiculo_Grupo7.Interfaz
{
    partial class HistoMan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVEHICULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadobandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempousoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAAPDataSet = new WindowsFormsApplication1.sistemaAAPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.mantenimientoTableAdapter = new WindowsFormsApplication1.sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.pARAMETROToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pARAMETROToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HISTORIAL DE MANTENIMIENTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMantenimientoDataGridViewTextBoxColumn,
            this.iDVEHICULODataGridViewTextBoxColumn,
            this.estadobandaDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn,
            this.fechamantenimientoDataGridViewTextBoxColumn,
            this.tiempousoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mantenimientoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // idMantenimientoDataGridViewTextBoxColumn
            // 
            this.idMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "idMantenimiento";
            this.idMantenimientoDataGridViewTextBoxColumn.HeaderText = "idMantenimiento";
            this.idMantenimientoDataGridViewTextBoxColumn.Name = "idMantenimientoDataGridViewTextBoxColumn";
            this.idMantenimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMantenimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDVEHICULODataGridViewTextBoxColumn
            // 
            this.iDVEHICULODataGridViewTextBoxColumn.DataPropertyName = "IDVEHICULO";
            this.iDVEHICULODataGridViewTextBoxColumn.HeaderText = "IDVEHICULO";
            this.iDVEHICULODataGridViewTextBoxColumn.Name = "iDVEHICULODataGridViewTextBoxColumn";
            this.iDVEHICULODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVEHICULODataGridViewTextBoxColumn.Visible = false;
            // 
            // estadobandaDataGridViewTextBoxColumn
            // 
            this.estadobandaDataGridViewTextBoxColumn.DataPropertyName = "estado_banda";
            this.estadobandaDataGridViewTextBoxColumn.HeaderText = "ESTADO DEL ACEITE";
            this.estadobandaDataGridViewTextBoxColumn.Name = "estadobandaDataGridViewTextBoxColumn";
            this.estadobandaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "KILOMETRAJE";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            this.kilometrajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechamantenimientoDataGridViewTextBoxColumn
            // 
            this.fechamantenimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_mantenimiento";
            this.fechamantenimientoDataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fechamantenimientoDataGridViewTextBoxColumn.Name = "fechamantenimientoDataGridViewTextBoxColumn";
            this.fechamantenimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempousoDataGridViewTextBoxColumn
            // 
            this.tiempousoDataGridViewTextBoxColumn.DataPropertyName = "tiempo_uso";
            this.tiempousoDataGridViewTextBoxColumn.HeaderText = "TIEMPO DE USO";
            this.tiempousoDataGridViewTextBoxColumn.Name = "tiempousoDataGridViewTextBoxColumn";
            this.tiempousoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.sistemaAAPDataSet;
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
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Módulo De Vehiculo";
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(320, 409);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(142, 29);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pARAMETROToolStripLabel1,
            this.pARAMETROToolStripTextBox1,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // pARAMETROToolStripLabel1
            // 
            this.pARAMETROToolStripLabel1.Name = "pARAMETROToolStripLabel1";
            this.pARAMETROToolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.pARAMETROToolStripLabel1.Text = "PARAMETRO:";
            // 
            // pARAMETROToolStripTextBox1
            // 
            this.pARAMETROToolStripTextBox1.Name = "pARAMETROToolStripTextBox1";
            this.pARAMETROToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // HistoMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HistoMan";
            this.Text = "HistoMan";
            this.Load += new System.EventHandler(this.HistoMan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVEHICULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadobandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempousoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel pARAMETROToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox pARAMETROToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}