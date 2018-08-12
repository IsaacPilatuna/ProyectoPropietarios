namespace WindowsFormsApplication1.ModuloReportesEstadisticos
{
    partial class FrmMenuPrincipalReportes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageViajes = new System.Windows.Forms.TabPage();
            this.tabPageCalificacion = new System.Windows.Forms.TabPage();
            this.tabPageVehiculo = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.49652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.50348F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 21);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo de Reportes Estadísticos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageViajes);
            this.tabControl1.Controls.Add(this.tabPageCalificacion);
            this.tabControl1.Controls.Add(this.tabPageVehiculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 398);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageViajes
            // 
            this.tabPageViajes.Location = new System.Drawing.Point(4, 29);
            this.tabPageViajes.Name = "tabPageViajes";
            this.tabPageViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViajes.Size = new System.Drawing.Size(780, 365);
            this.tabPageViajes.TabIndex = 0;
            this.tabPageViajes.Text = "Reporte de Viajes";
            this.tabPageViajes.UseVisualStyleBackColor = true;
            // 
            // tabPageCalificacion
            // 
            this.tabPageCalificacion.Location = new System.Drawing.Point(4, 29);
            this.tabPageCalificacion.Name = "tabPageCalificacion";
            this.tabPageCalificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalificacion.Size = new System.Drawing.Size(780, 365);
            this.tabPageCalificacion.TabIndex = 1;
            this.tabPageCalificacion.Text = "Reporte de Calificación de Servicio";
            this.tabPageCalificacion.UseVisualStyleBackColor = true;
            // 
            // tabPageVehiculo
            // 
            this.tabPageVehiculo.Location = new System.Drawing.Point(4, 29);
            this.tabPageVehiculo.Name = "tabPageVehiculo";
            this.tabPageVehiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehiculo.Size = new System.Drawing.Size(780, 365);
            this.tabPageVehiculo.TabIndex = 2;
            this.tabPageVehiculo.Text = "Reporte de Vehículos";
            this.tabPageVehiculo.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipalReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipalReportes";
            this.Text = "FrmMenuPrincipalReportes";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageViajes;
        private System.Windows.Forms.TabPage tabPageCalificacion;
        private System.Windows.Forms.TabPage tabPageVehiculo;
    }
}