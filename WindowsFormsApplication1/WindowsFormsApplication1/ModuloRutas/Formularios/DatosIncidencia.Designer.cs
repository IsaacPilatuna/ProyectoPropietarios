namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    partial class DatosIncidencia
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
            this.dataIncidecia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataIncidecia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataIncidecia
            // 
            this.dataIncidecia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIncidecia.Location = new System.Drawing.Point(85, 125);
            this.dataIncidecia.Name = "dataIncidecia";
            this.dataIncidecia.RowTemplate.Height = 24;
            this.dataIncidecia.Size = new System.Drawing.Size(646, 251);
            this.dataIncidecia.TabIndex = 0;
            this.dataIncidecia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIncidecia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "INCIDENCIAS";
            // 
            // DatosIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataIncidecia);
            this.Name = "DatosIncidencia";
            this.Text = "DatosIncidencia";
            this.Load += new System.EventHandler(this.DatosIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataIncidecia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataIncidecia;
        private System.Windows.Forms.Label label1;
    }
}