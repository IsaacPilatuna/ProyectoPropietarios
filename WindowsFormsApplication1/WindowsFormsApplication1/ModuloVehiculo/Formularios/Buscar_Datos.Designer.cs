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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pLACAVEHICULOLabel = new System.Windows.Forms.Label();
            this.pLACAVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscar.Location = new System.Drawing.Point(253, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pLACAVEHICULOLabel
            // 
            this.pLACAVEHICULOLabel.AutoSize = true;
            this.pLACAVEHICULOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pLACAVEHICULOLabel.Location = new System.Drawing.Point(83, 44);
            this.pLACAVEHICULOLabel.Name = "pLACAVEHICULOLabel";
            this.pLACAVEHICULOLabel.Size = new System.Drawing.Size(119, 13);
            this.pLACAVEHICULOLabel.TabIndex = 1;
            this.pLACAVEHICULOLabel.Text = "PLACA DE VEHICULO:";
            // 
            // pLACAVEHICULOComboBox
            // 
            this.pLACAVEHICULOComboBox.FormattingEnabled = true;
            this.pLACAVEHICULOComboBox.Location = new System.Drawing.Point(228, 44);
            this.pLACAVEHICULOComboBox.Name = "pLACAVEHICULOComboBox";
            this.pLACAVEHICULOComboBox.Size = new System.Drawing.Size(121, 21);
            this.pLACAVEHICULOComboBox.TabIndex = 2;
            // 
            // Buscar_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pLACAVEHICULOComboBox);
            this.Controls.Add(this.pLACAVEHICULOLabel);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Buscar_Datos";
            this.Text = "Buscar_Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label pLACAVEHICULOLabel;
        private System.Windows.Forms.ComboBox pLACAVEHICULOComboBox;
    }
}