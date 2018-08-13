namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    partial class Incidencia
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
            System.Windows.Forms.Label pLACAVEHICULOLabel1;
            System.Windows.Forms.Label incidenciaIDLabel;
            System.Windows.Forms.Label horaIncidenciaLabel;
            System.Windows.Forms.Label fechaIncidenciaLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.PLACAVEHICULO = new System.Windows.Forms.ComboBox();
            this.incidenciaID = new System.Windows.Forms.TextBox();
            this.horaIncidencia = new System.Windows.Forms.TextBox();
            this.fechaIncidencia = new System.Windows.Forms.DateTimePicker();
            this.descripcionD = new System.Windows.Forms.TextBox();
            this.GUARDAR = new System.Windows.Forms.Button();
            pLACAVEHICULOLabel1 = new System.Windows.Forms.Label();
            incidenciaIDLabel = new System.Windows.Forms.Label();
            horaIncidenciaLabel = new System.Windows.Forms.Label();
            fechaIncidenciaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pLACAVEHICULOLabel1
            // 
            pLACAVEHICULOLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pLACAVEHICULOLabel1.AutoSize = true;
            pLACAVEHICULOLabel1.Location = new System.Drawing.Point(171, 215);
            pLACAVEHICULOLabel1.Name = "pLACAVEHICULOLabel1";
            pLACAVEHICULOLabel1.Size = new System.Drawing.Size(125, 17);
            pLACAVEHICULOLabel1.TabIndex = 21;
            pLACAVEHICULOLabel1.Text = "PLACAVEHICULO:";
            // 
            // incidenciaIDLabel
            // 
            incidenciaIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            incidenciaIDLabel.AutoSize = true;
            incidenciaIDLabel.Location = new System.Drawing.Point(171, 104);
            incidenciaIDLabel.Name = "incidenciaIDLabel";
            incidenciaIDLabel.Size = new System.Drawing.Size(92, 17);
            incidenciaIDLabel.TabIndex = 13;
            incidenciaIDLabel.Text = "incidencia ID:";
            // 
            // horaIncidenciaLabel
            // 
            horaIncidenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            horaIncidenciaLabel.AutoSize = true;
            horaIncidenciaLabel.Location = new System.Drawing.Point(171, 132);
            horaIncidenciaLabel.Name = "horaIncidenciaLabel";
            horaIncidenciaLabel.Size = new System.Drawing.Size(108, 17);
            horaIncidenciaLabel.TabIndex = 15;
            horaIncidenciaLabel.Text = "hora Incidencia:";
            // 
            // fechaIncidenciaLabel
            // 
            fechaIncidenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fechaIncidenciaLabel.AutoSize = true;
            fechaIncidenciaLabel.Location = new System.Drawing.Point(171, 161);
            fechaIncidenciaLabel.Name = "fechaIncidenciaLabel";
            fechaIncidenciaLabel.Size = new System.Drawing.Size(114, 17);
            fechaIncidenciaLabel.TabIndex = 17;
            fechaIncidenciaLabel.Text = "fecha Incidencia:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(171, 188);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(84, 17);
            descripcionLabel.TabIndex = 19;
            descripcionLabel.Text = "descripcion:";
            // 
            // PLACAVEHICULO
            // 
            this.PLACAVEHICULO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLACAVEHICULO.DisplayMember = "PLACAVEHICULO";
            this.PLACAVEHICULO.FormattingEnabled = true;
            this.PLACAVEHICULO.Location = new System.Drawing.Point(302, 215);
            this.PLACAVEHICULO.Name = "PLACAVEHICULO";
            this.PLACAVEHICULO.Size = new System.Drawing.Size(319, 24);
            this.PLACAVEHICULO.TabIndex = 22;
            this.PLACAVEHICULO.ValueMember = "PLACAVEHICULO";
            this.PLACAVEHICULO.SelectedIndexChanged += new System.EventHandler(this.PLACAVEHICULO_SelectedIndexChanged);
            // 
            // incidenciaID
            // 
            this.incidenciaID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incidenciaID.Location = new System.Drawing.Point(302, 101);
            this.incidenciaID.Name = "incidenciaID";
            this.incidenciaID.Size = new System.Drawing.Size(319, 22);
            this.incidenciaID.TabIndex = 14;
            this.incidenciaID.TextChanged += new System.EventHandler(this.incidenciaIDTextBox_TextChanged);
            // 
            // horaIncidencia
            // 
            this.horaIncidencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horaIncidencia.Location = new System.Drawing.Point(302, 129);
            this.horaIncidencia.Name = "horaIncidencia";
            this.horaIncidencia.Size = new System.Drawing.Size(319, 22);
            this.horaIncidencia.TabIndex = 16;
            this.horaIncidencia.TextChanged += new System.EventHandler(this.horaIncidencia_TextChanged);
            // 
            // fechaIncidencia
            // 
            this.fechaIncidencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaIncidencia.CustomFormat = "yyyy-MM-dd";
            this.fechaIncidencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIncidencia.Location = new System.Drawing.Point(302, 157);
            this.fechaIncidencia.Name = "fechaIncidencia";
            this.fechaIncidencia.Size = new System.Drawing.Size(319, 22);
            this.fechaIncidencia.TabIndex = 18;
            this.fechaIncidencia.ValueChanged += new System.EventHandler(this.fechaIncidencia_ValueChanged);
            // 
            // descripcionD
            // 
            this.descripcionD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionD.Location = new System.Drawing.Point(302, 185);
            this.descripcionD.Name = "descripcionD";
            this.descripcionD.Size = new System.Drawing.Size(319, 22);
            this.descripcionD.TabIndex = 20;
            this.descripcionD.TextChanged += new System.EventHandler(this.descripcionD_TextChanged);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(330, 293);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(167, 43);
            this.GUARDAR.TabIndex = 23;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(pLACAVEHICULOLabel1);
            this.Controls.Add(this.PLACAVEHICULO);
            this.Controls.Add(incidenciaIDLabel);
            this.Controls.Add(this.incidenciaID);
            this.Controls.Add(horaIncidenciaLabel);
            this.Controls.Add(this.horaIncidencia);
            this.Controls.Add(fechaIncidenciaLabel);
            this.Controls.Add(this.fechaIncidencia);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionD);
            this.Name = "Incidencia";
            this.Text = "Incidencia";
            this.Load += new System.EventHandler(this.Incidencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PLACAVEHICULO;
        private System.Windows.Forms.TextBox incidenciaID;
        private System.Windows.Forms.TextBox horaIncidencia;
        private System.Windows.Forms.DateTimePicker fechaIncidencia;
        private System.Windows.Forms.TextBox descripcionD;
        private System.Windows.Forms.Button GUARDAR;
    }
}