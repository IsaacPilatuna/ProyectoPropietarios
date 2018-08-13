namespace WindowsFormsApplication1.ModuloRutas.Formularios
{ 
    partial class Kilometraje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idHistorial = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.textkilometraje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBPlaca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "id Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "id Historial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kilometraje";
            // 
            // idHistorial
            // 
            this.idHistorial.Location = new System.Drawing.Point(354, 69);
            this.idHistorial.Name = "idHistorial";
            this.idHistorial.Size = new System.Drawing.Size(200, 22);
            this.idHistorial.TabIndex = 5;
            this.idHistorial.TextChanged += new System.EventHandler(this.idHistorial_TextChanged);
            // 
            // time
            // 
            this.time.CustomFormat = "yyyy-MM-dd";
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(354, 123);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 22);
            this.time.TabIndex = 6;
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // textkilometraje
            // 
            this.textkilometraje.Location = new System.Drawing.Point(354, 182);
            this.textkilometraje.Name = "textkilometraje";
            this.textkilometraje.Size = new System.Drawing.Size(200, 22);
            this.textkilometraje.TabIndex = 7;
            this.textkilometraje.TextChanged += new System.EventHandler(this.textkilometraje_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBPlaca
            // 
            this.CBPlaca.FormattingEnabled = true;
            this.CBPlaca.Location = new System.Drawing.Point(354, 229);
            this.CBPlaca.Name = "CBPlaca";
            this.CBPlaca.Size = new System.Drawing.Size(200, 24);
            this.CBPlaca.TabIndex = 9;
            this.CBPlaca.SelectedIndexChanged += new System.EventHandler(this.CBPlaca_SelectedIndexChanged_1);
            // 
            // Kilometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBPlaca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textkilometraje);
            this.Controls.Add(this.time);
            this.Controls.Add(this.idHistorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kilometraje";
            this.Text = "Kilometraje";
            this.Load += new System.EventHandler(this.Kilometraje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idHistorial;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.TextBox textkilometraje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBPlaca;
        // private System.Windows.Forms.TextBox kilo;
    }
}