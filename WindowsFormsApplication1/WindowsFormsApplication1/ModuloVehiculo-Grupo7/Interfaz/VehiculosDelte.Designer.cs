namespace ModuloVehiculo.Interfaz
{
    partial class VehiculosDelte
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sistemaAAPDataSet = new WindowsFormsApplication1.sistemaAAPDataSet();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULOTableAdapter = new WindowsFormsApplication1.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter();
            this.IDVEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACAVEHICULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOVEHICULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPasajerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo De Vehiculo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELIMINAR VEHICULO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVEHICULO,
            this.pLACAVEHICULODataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.tIPOVEHICULODataGridViewTextBoxColumn,
            this.numeroPasajerosDataGridViewTextBoxColumn,
            this.anioVehiculoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vEHICULOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sistemaAAPDataSet
            // 
            this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            this.vEHICULOBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // vEHICULOTableAdapter
            // 
            this.vEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // IDVEHICULO
            // 
            this.IDVEHICULO.DataPropertyName = "IDVEHICULO";
            this.IDVEHICULO.HeaderText = "IDVEHICULO";
            this.IDVEHICULO.Name = "IDVEHICULO";
            this.IDVEHICULO.ReadOnly = true;
            this.IDVEHICULO.Visible = false;
            // 
            // pLACAVEHICULODataGridViewTextBoxColumn
            // 
            this.pLACAVEHICULODataGridViewTextBoxColumn.DataPropertyName = "PLACAVEHICULO";
            this.pLACAVEHICULODataGridViewTextBoxColumn.HeaderText = "PLACA";
            this.pLACAVEHICULODataGridViewTextBoxColumn.Name = "pLACAVEHICULODataGridViewTextBoxColumn";
            this.pLACAVEHICULODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "MATRICULA";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "MATRICULA";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOVEHICULODataGridViewTextBoxColumn
            // 
            this.tIPOVEHICULODataGridViewTextBoxColumn.DataPropertyName = "TIPOVEHICULO";
            this.tIPOVEHICULODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPOVEHICULODataGridViewTextBoxColumn.Name = "tIPOVEHICULODataGridViewTextBoxColumn";
            this.tIPOVEHICULODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPasajerosDataGridViewTextBoxColumn
            // 
            this.numeroPasajerosDataGridViewTextBoxColumn.DataPropertyName = "numeroPasajeros";
            this.numeroPasajerosDataGridViewTextBoxColumn.HeaderText = "CAPACIDAD";
            this.numeroPasajerosDataGridViewTextBoxColumn.Name = "numeroPasajerosDataGridViewTextBoxColumn";
            this.numeroPasajerosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anioVehiculoDataGridViewTextBoxColumn
            // 
            this.anioVehiculoDataGridViewTextBoxColumn.DataPropertyName = "anioVehiculo";
            this.anioVehiculoDataGridViewTextBoxColumn.HeaderText = "AÑO";
            this.anioVehiculoDataGridViewTextBoxColumn.Name = "anioVehiculoDataGridViewTextBoxColumn";
            this.anioVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VehiculosDelte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "VehiculosDelte";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosDelte_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private WindowsFormsApplication1.sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private WindowsFormsApplication1.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACAVEHICULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOVEHICULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPasajerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioVehiculoDataGridViewTextBoxColumn;
    }
}