﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.numeroPersonas = new System.Windows.Forms.Label();
            this.tipoUsuario = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.fechaFinaliza = new System.Windows.Forms.DateTimePicker();
            this.reservacion = new System.Windows.Forms.Button();
            this.numReserva = new System.Windows.Forms.Label();
            this.numReservaTxt = new System.Windows.Forms.TextBox();
            this.confirmarBtn = new System.Windows.Forms.Button();
            this.tipoUsr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motivoViajeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroPersonas
            // 
            this.numeroPersonas.AutoSize = true;
            this.numeroPersonas.Location = new System.Drawing.Point(110, 251);
            this.numeroPersonas.Name = "numeroPersonas";
            this.numeroPersonas.Size = new System.Drawing.Size(106, 13);
            this.numeroPersonas.TabIndex = 0;
            this.numeroPersonas.Text = "Numero de Personas";
            this.numeroPersonas.Click += new System.EventHandler(this.label1_Click);
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.AutoSize = true;
            this.tipoUsuario.Location = new System.Drawing.Point(110, 310);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(80, 13);
            this.tipoUsuario.TabIndex = 1;
            this.tipoUsuario.Text = "Tipo de usuario";
            this.tipoUsuario.Click += new System.EventHandler(this.tipoUsuario_Click);
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Location = new System.Drawing.Point(110, 344);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(80, 13);
            this.fechaInicio.TabIndex = 2;
            this.fechaInicio.Text = "Fecha de Inicio";
            // 
            // fechaFin
            // 
            this.fechaFin.AutoSize = true;
            this.fechaFin.Location = new System.Drawing.Point(110, 375);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(69, 13);
            this.fechaFin.TabIndex = 3;
            this.fechaFin.Text = "Fecha de Fin";
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(233, 249);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 20);
            this.numPersonas.TabIndex = 4;
            // 
            // fechaIni
            // 
            this.fechaIni.Location = new System.Drawing.Point(233, 344);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(121, 20);
            this.fechaIni.TabIndex = 6;
            // 
            // fechaFinaliza
            // 
            this.fechaFinaliza.Location = new System.Drawing.Point(233, 375);
            this.fechaFinaliza.Name = "fechaFinaliza";
            this.fechaFinaliza.Size = new System.Drawing.Size(120, 20);
            this.fechaFinaliza.TabIndex = 7;
            // 
            // reservacion
            // 
            this.reservacion.Location = new System.Drawing.Point(112, 426);
            this.reservacion.Name = "reservacion";
            this.reservacion.Size = new System.Drawing.Size(101, 21);
            this.reservacion.TabIndex = 8;
            this.reservacion.Text = "Consultar";
            this.reservacion.UseVisualStyleBackColor = true;
            this.reservacion.Click += new System.EventHandler(this.reservacion_Click);
            // 
            // numReserva
            // 
            this.numReserva.AutoSize = true;
            this.numReserva.Location = new System.Drawing.Point(112, 215);
            this.numReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numReserva.Name = "numReserva";
            this.numReserva.Size = new System.Drawing.Size(102, 13);
            this.numReserva.TabIndex = 9;
            this.numReserva.Text = "Numero de Reserva";
            // 
            // numReservaTxt
            // 
            this.numReservaTxt.Location = new System.Drawing.Point(233, 215);
            this.numReservaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.numReservaTxt.Name = "numReservaTxt";
            this.numReservaTxt.Size = new System.Drawing.Size(120, 20);
            this.numReservaTxt.TabIndex = 10;
            // 
            // confirmarBtn
            // 
            this.confirmarBtn.Location = new System.Drawing.Point(242, 428);
            this.confirmarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBtn.Name = "confirmarBtn";
            this.confirmarBtn.Size = new System.Drawing.Size(92, 20);
            this.confirmarBtn.TabIndex = 11;
            this.confirmarBtn.Text = "Confirmar";
            this.confirmarBtn.UseVisualStyleBackColor = true;
            this.confirmarBtn.Click += new System.EventHandler(this.confirmarBtn_Click);
            // 
            // tipoUsr
            // 
            this.tipoUsr.Location = new System.Drawing.Point(233, 310);
            this.tipoUsr.Margin = new System.Windows.Forms.Padding(2);
            this.tipoUsr.Name = "tipoUsr";
            this.tipoUsr.Size = new System.Drawing.Size(120, 20);
            this.tipoUsr.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Motivo Viaje";
            // 
            // motivoViajeTxt
            // 
            this.motivoViajeTxt.Location = new System.Drawing.Point(233, 277);
            this.motivoViajeTxt.Name = "motivoViajeTxt";
            this.motivoViajeTxt.Size = new System.Drawing.Size(120, 20);
            this.motivoViajeTxt.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(233, 186);
            this.nombreText.Margin = new System.Windows.Forms.Padding(2);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(120, 20);
            this.nombreText.TabIndex = 17;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(112, 186);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(113, 13);
            this.nombreLabel.TabIndex = 16;
            this.nombreLabel.Text = "Nombre del Solicitante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.motivoViajeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoUsr);
            this.Controls.Add(this.confirmarBtn);
            this.Controls.Add(this.numReservaTxt);
            this.Controls.Add(this.numReserva);
            this.Controls.Add(this.reservacion);
            this.Controls.Add(this.fechaFinaliza);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.numeroPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroPersonas;
        private System.Windows.Forms.Label tipoUsuario;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label fechaFin;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.DateTimePicker fechaFinaliza;
        private System.Windows.Forms.Button reservacion;
        private System.Windows.Forms.Label numReserva;
        private System.Windows.Forms.TextBox numReservaTxt;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.TextBox tipoUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motivoViajeTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label nombreLabel;
    }
}

