namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class mdiModVehiculo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.datosVehiculoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.disponibilidadToolStripMenuItem,
            this.incidenciasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadToolStripMenuItem_Click);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            this.incidenciasToolStripMenuItem.Click += new System.EventHandler(this.incidenciasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculoToolStripMenuItem1,
            this.mantenimientoToolStripMenuItem1,
            this.disponibilidadToolStripMenuItem1,
            this.incidenciasToolStripMenuItem1});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // vehiculoToolStripMenuItem1
            // 
            this.vehiculoToolStripMenuItem1.Name = "vehiculoToolStripMenuItem1";
            this.vehiculoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vehiculoToolStripMenuItem1.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem1.Click += new System.EventHandler(this.vehiculoToolStripMenuItem1_Click);
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem1.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem1_Click);
            // 
            // disponibilidadToolStripMenuItem1
            // 
            this.disponibilidadToolStripMenuItem1.Name = "disponibilidadToolStripMenuItem1";
            this.disponibilidadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.disponibilidadToolStripMenuItem1.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem1.Click += new System.EventHandler(this.disponibilidadToolStripMenuItem1_Click);
            // 
            // incidenciasToolStripMenuItem1
            // 
            this.incidenciasToolStripMenuItem1.Name = "incidenciasToolStripMenuItem1";
            this.incidenciasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.incidenciasToolStripMenuItem1.Text = "Incidencias";
            this.incidenciasToolStripMenuItem1.Click += new System.EventHandler(this.incidenciasToolStripMenuItem1_Click);
            // 
            // datosVehiculoToolStripMenuItem
            // 
            this.datosVehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarDatosToolStripMenuItem});
            this.datosVehiculoToolStripMenuItem.Name = "datosVehiculoToolStripMenuItem";
            this.datosVehiculoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.datosVehiculoToolStripMenuItem.Text = "Datos Vehiculo";
            // 
            // buscarDatosToolStripMenuItem
            // 
            this.buscarDatosToolStripMenuItem.Name = "buscarDatosToolStripMenuItem";
            this.buscarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarDatosToolStripMenuItem.Text = "Buscar Datos";
            this.buscarDatosToolStripMenuItem.Click += new System.EventHandler(this.buscarDatosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 378);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mdiModVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiModVehiculo";
            this.Text = "Modulo Vehiculo";
            this.Load += new System.EventHandler(this.mdiModVehiculo_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDatosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}



