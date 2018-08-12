namespace ModuloFormularios
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idConductor = new System.Windows.Forms.TextBox();
            this.txt_nombreConductor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_inconvenienteT = new System.Windows.Forms.RadioButton();
            this.rb_inconvenienteF = new System.Windows.Forms.RadioButton();
            this.txt_descIncon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_0 = new System.Windows.Forms.RadioButton();
            this.rb_25 = new System.Windows.Forms.RadioButton();
            this.rb_50 = new System.Windows.Forms.RadioButton();
            this.rb_75 = new System.Windows.Forms.RadioButton();
            this.rb_100 = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_dinCombustible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_reservas = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE VIAJE COMPLETADO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_idConductor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombreConductor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_descIncon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_dinCombustible, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_reservas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_guardar, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 415);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(2, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad de dinero gastada en combustible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(2, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripción del incoveniente (máx. 30 caracteres)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del Conductor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres Completos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(2, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "¿El vehículo presentó inconvenientes durante el viaje? ";
            // 
            // txt_idConductor
            // 
            this.txt_idConductor.Enabled = false;
            this.txt_idConductor.Location = new System.Drawing.Point(370, 43);
            this.txt_idConductor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_idConductor.Multiline = true;
            this.txt_idConductor.Name = "txt_idConductor";
            this.txt_idConductor.Size = new System.Drawing.Size(297, 25);
            this.txt_idConductor.TabIndex = 3;
            // 
            // txt_nombreConductor
            // 
            this.txt_nombreConductor.Enabled = false;
            this.txt_nombreConductor.Location = new System.Drawing.Point(370, 97);
            this.txt_nombreConductor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreConductor.Multiline = true;
            this.txt_nombreConductor.Name = "txt_nombreConductor";
            this.txt_nombreConductor.Size = new System.Drawing.Size(297, 26);
            this.txt_nombreConductor.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rb_inconvenienteT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_inconvenienteF, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(370, 153);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 37);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // rb_inconvenienteT
            // 
            this.rb_inconvenienteT.AutoSize = true;
            this.rb_inconvenienteT.Checked = true;
            this.rb_inconvenienteT.Location = new System.Drawing.Point(2, 2);
            this.rb_inconvenienteT.Margin = new System.Windows.Forms.Padding(2);
            this.rb_inconvenienteT.Name = "rb_inconvenienteT";
            this.rb_inconvenienteT.Size = new System.Drawing.Size(36, 17);
            this.rb_inconvenienteT.TabIndex = 0;
            this.rb_inconvenienteT.TabStop = true;
            this.rb_inconvenienteT.Text = "Sí";
            this.rb_inconvenienteT.UseVisualStyleBackColor = true;
            this.rb_inconvenienteT.CheckedChanged += new System.EventHandler(this.rb_inconvenienteT_CheckedChanged);
            // 
            // rb_inconvenienteF
            // 
            this.rb_inconvenienteF.AutoSize = true;
            this.rb_inconvenienteF.Location = new System.Drawing.Point(150, 2);
            this.rb_inconvenienteF.Margin = new System.Windows.Forms.Padding(2);
            this.rb_inconvenienteF.Name = "rb_inconvenienteF";
            this.rb_inconvenienteF.Size = new System.Drawing.Size(39, 17);
            this.rb_inconvenienteF.TabIndex = 1;
            this.rb_inconvenienteF.Text = "No";
            this.rb_inconvenienteF.UseVisualStyleBackColor = true;
            this.rb_inconvenienteF.CheckedChanged += new System.EventHandler(this.rb_inconvenienteF_CheckedChanged);
            // 
            // txt_descIncon
            // 
            this.txt_descIncon.Location = new System.Drawing.Point(370, 207);
            this.txt_descIncon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descIncon.Multiline = true;
            this.txt_descIncon.Name = "txt_descIncon";
            this.txt_descIncon.Size = new System.Drawing.Size(297, 69);
            this.txt_descIncon.TabIndex = 6;
            this.txt_descIncon.Tag = "";
            this.txt_descIncon.Text = "Descripción del inconveniente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(2, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Califique el comportamiento de el/los pasajeros";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rb_0, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_25, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_50, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_75, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_100, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(370, 324);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 36);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // rb_0
            // 
            this.rb_0.AutoSize = true;
            this.rb_0.Location = new System.Drawing.Point(2, 2);
            this.rb_0.Margin = new System.Windows.Forms.Padding(2);
            this.rb_0.Name = "rb_0";
            this.rb_0.Size = new System.Drawing.Size(31, 17);
            this.rb_0.TabIndex = 0;
            this.rb_0.TabStop = true;
            this.rb_0.Text = "0";
            this.rb_0.UseVisualStyleBackColor = true;
            // 
            // rb_25
            // 
            this.rb_25.AutoSize = true;
            this.rb_25.Location = new System.Drawing.Point(61, 2);
            this.rb_25.Margin = new System.Windows.Forms.Padding(2);
            this.rb_25.Name = "rb_25";
            this.rb_25.Size = new System.Drawing.Size(37, 17);
            this.rb_25.TabIndex = 1;
            this.rb_25.TabStop = true;
            this.rb_25.Text = "25";
            this.rb_25.UseVisualStyleBackColor = true;
            // 
            // rb_50
            // 
            this.rb_50.Checked = true;
            this.rb_50.Location = new System.Drawing.Point(120, 2);
            this.rb_50.Margin = new System.Windows.Forms.Padding(2);
            this.rb_50.Name = "rb_50";
            this.rb_50.Size = new System.Drawing.Size(37, 17);
            this.rb_50.TabIndex = 2;
            this.rb_50.TabStop = true;
            this.rb_50.Text = "50";
            this.rb_50.UseVisualStyleBackColor = true;
            // 
            // rb_75
            // 
            this.rb_75.AutoSize = true;
            this.rb_75.Location = new System.Drawing.Point(179, 2);
            this.rb_75.Margin = new System.Windows.Forms.Padding(2);
            this.rb_75.Name = "rb_75";
            this.rb_75.Size = new System.Drawing.Size(37, 17);
            this.rb_75.TabIndex = 3;
            this.rb_75.TabStop = true;
            this.rb_75.Text = "75";
            this.rb_75.UseVisualStyleBackColor = true;
            // 
            // rb_100
            // 
            this.rb_100.AutoSize = true;
            this.rb_100.Location = new System.Drawing.Point(238, 2);
            this.rb_100.Margin = new System.Windows.Forms.Padding(2);
            this.rb_100.Name = "rb_100";
            this.rb_100.Size = new System.Drawing.Size(43, 17);
            this.rb_100.TabIndex = 4;
            this.rb_100.TabStop = true;
            this.rb_100.Text = "100";
            this.rb_100.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(2, 365);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 34);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.obtenerDatos);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_dinCombustible
            // 
            this.txt_dinCombustible.Location = new System.Drawing.Point(370, 280);
            this.txt_dinCombustible.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dinCombustible.Multiline = true;
            this.txt_dinCombustible.Name = "txt_dinCombustible";
            this.txt_dinCombustible.Size = new System.Drawing.Size(157, 19);
            this.txt_dinCombustible.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código de la Reserva";
            // 
            // cb_reservas
            // 
            this.cb_reservas.FormattingEnabled = true;
            this.cb_reservas.Location = new System.Drawing.Point(371, 3);
            this.cb_reservas.Name = "cb_reservas";
            this.cb_reservas.Size = new System.Drawing.Size(295, 21);
            this.cb_reservas.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(679, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idConductor;
        private System.Windows.Forms.TextBox txt_nombreConductor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rb_inconvenienteT;
        private System.Windows.Forms.RadioButton rb_inconvenienteF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descIncon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dinCombustible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_0;
        private System.Windows.Forms.RadioButton rb_25;
        private System.Windows.Forms.RadioButton rb_50;
        private System.Windows.Forms.RadioButton rb_75;
        private System.Windows.Forms.RadioButton rb_100;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_reservas;
    }
}