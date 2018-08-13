namespace ModuloVehiculo.Interfaz
{
    partial class FormularioIngresoIM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTUso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Módulo De Vehiculo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTUso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datFecha);
            this.groupBox1.Controls.Add(this.txtEA);
            this.groupBox1.Controls.Add(this.txtKilometraje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE EL ÚLTIMO MANTENIMIENTO";
            // 
            // txtTUso
            // 
            this.txtTUso.Location = new System.Drawing.Point(212, 123);
            this.txtTUso.Name = "txtTUso";
            this.txtTUso.Size = new System.Drawing.Size(135, 20);
            this.txtTUso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiempo de Uso:";
            // 
            // datFecha
            // 
            this.datFecha.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.datFecha.CustomFormat = "yyyy-MM-dd";
            this.datFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datFecha.Location = new System.Drawing.Point(212, 60);
            this.datFecha.Name = "datFecha";
            this.datFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datFecha.Size = new System.Drawing.Size(135, 20);
            this.datFecha.TabIndex = 6;
            this.datFecha.Value = new System.DateTime(2018, 8, 12, 0, 0, 0, 0);
            // 
            // txtEA
            // 
            this.txtEA.Location = new System.Drawing.Point(212, 152);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(135, 20);
            this.txtEA.TabIndex = 5;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(212, 86);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(135, 20);
            this.txtKilometraje.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado del Aceite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kilometraje:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(176, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormularioIngresoIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 325);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormularioIngresoIM";
            this.Text = "FormularioIngresoIM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtTUso;
        private System.Windows.Forms.Label label5;
    }
}