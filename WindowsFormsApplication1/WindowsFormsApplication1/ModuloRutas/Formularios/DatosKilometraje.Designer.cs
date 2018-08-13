namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    partial class DatosKilometraje
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataKilometraje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataKilometraje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL KILOMETRAJE";
            // 
            // dataKilometraje
            // 
            this.dataKilometraje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKilometraje.Location = new System.Drawing.Point(103, 138);
            this.dataKilometraje.Name = "dataKilometraje";
            this.dataKilometraje.RowTemplate.Height = 24;
            this.dataKilometraje.Size = new System.Drawing.Size(638, 277);
            this.dataKilometraje.TabIndex = 1;
            this.dataKilometraje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DatosKilometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataKilometraje);
            this.Controls.Add(this.label1);
            this.Name = "DatosKilometraje";
            this.Text = "DatosKilometraje";
            this.Load += new System.EventHandler(this.DatosKilometraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKilometraje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataKilometraje;
    }
}