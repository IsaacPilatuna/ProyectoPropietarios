namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class FormMantenimiento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idMantenimientoLabel;
            System.Windows.Forms.Label estado_bandaLabel;
            System.Windows.Forms.Label kilometrajeLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label fecha_mantenimientoLabel;
            System.Windows.Forms.Label tiempo_usoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimiento));
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.mantenimientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idMantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.estado_bandaTextBox = new System.Windows.Forms.TextBox();
            this.kilometrajeTextBox = new System.Windows.Forms.TextBox();
            this.iDVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.fecha_mantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tiempo_usoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idMantenimientoLabel = new System.Windows.Forms.Label();
            estado_bandaLabel = new System.Windows.Forms.Label();
            kilometrajeLabel = new System.Windows.Forms.Label();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            fecha_mantenimientoLabel = new System.Windows.Forms.Label();
            tiempo_usoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).BeginInit();
            this.mantenimientoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calificacion_ServicioTableAdapter = null;
            this.tableAdapterManager.CargosTableAdapter = null;
            this.tableAdapterManager.CHOFERTableAdapter = null;
            this.tableAdapterManager.CuentaTableAdapter = null;
            this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            this.tableAdapterManager.MotivoViajeTableAdapter = null;
            this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // mantenimientoBindingNavigator
            // 
            this.mantenimientoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mantenimientoBindingNavigator.BackColor = System.Drawing.SystemColors.Highlight;
            this.mantenimientoBindingNavigator.BindingSource = this.mantenimientoBindingSource;
            this.mantenimientoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mantenimientoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mantenimientoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mantenimientoBindingNavigatorSaveItem});
            this.mantenimientoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mantenimientoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mantenimientoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mantenimientoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mantenimientoBindingNavigator.Name = "mantenimientoBindingNavigator";
            this.mantenimientoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mantenimientoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.mantenimientoBindingNavigator.TabIndex = 0;
            this.mantenimientoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idMantenimientoLabel
            // 
            idMantenimientoLabel.AutoSize = true;
            idMantenimientoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idMantenimientoLabel.Location = new System.Drawing.Point(179, 79);
            idMantenimientoLabel.Name = "idMantenimientoLabel";
            idMantenimientoLabel.Size = new System.Drawing.Size(93, 13);
            idMantenimientoLabel.TabIndex = 1;
            idMantenimientoLabel.Text = "ID Mantenimiento:";
            // 
            // idMantenimientoTextBox
            // 
            this.idMantenimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "idMantenimiento", true));
            this.idMantenimientoTextBox.Location = new System.Drawing.Point(312, 76);
            this.idMantenimientoTextBox.Name = "idMantenimientoTextBox";
            this.idMantenimientoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idMantenimientoTextBox.TabIndex = 2;
            // 
            // estado_bandaLabel
            // 
            estado_bandaLabel.AutoSize = true;
            estado_bandaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            estado_bandaLabel.Location = new System.Drawing.Point(179, 105);
            estado_bandaLabel.Name = "estado_bandaLabel";
            estado_bandaLabel.Size = new System.Drawing.Size(77, 13);
            estado_bandaLabel.TabIndex = 3;
            estado_bandaLabel.Text = "Estado Banda:";
            // 
            // estado_bandaTextBox
            // 
            this.estado_bandaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "estado_banda", true));
            this.estado_bandaTextBox.Location = new System.Drawing.Point(312, 102);
            this.estado_bandaTextBox.Name = "estado_bandaTextBox";
            this.estado_bandaTextBox.Size = new System.Drawing.Size(200, 20);
            this.estado_bandaTextBox.TabIndex = 4;
            // 
            // kilometrajeLabel
            // 
            kilometrajeLabel.AutoSize = true;
            kilometrajeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            kilometrajeLabel.Location = new System.Drawing.Point(179, 131);
            kilometrajeLabel.Name = "kilometrajeLabel";
            kilometrajeLabel.Size = new System.Drawing.Size(58, 13);
            kilometrajeLabel.TabIndex = 5;
            kilometrajeLabel.Text = "Kilometraje";
            // 
            // kilometrajeTextBox
            // 
            this.kilometrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "kilometraje", true));
            this.kilometrajeTextBox.Location = new System.Drawing.Point(312, 128);
            this.kilometrajeTextBox.Name = "kilometrajeTextBox";
            this.kilometrajeTextBox.Size = new System.Drawing.Size(200, 20);
            this.kilometrajeTextBox.TabIndex = 6;
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            iDVEHICULOLabel.Location = new System.Drawing.Point(179, 157);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(65, 13);
            iDVEHICULOLabel.TabIndex = 7;
            iDVEHICULOLabel.Text = "ID Vehiculo:";
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(312, 154);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDVEHICULOTextBox.TabIndex = 8;
            // 
            // fecha_mantenimientoLabel
            // 
            fecha_mantenimientoLabel.AutoSize = true;
            fecha_mantenimientoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fecha_mantenimientoLabel.Location = new System.Drawing.Point(179, 184);
            fecha_mantenimientoLabel.Name = "fecha_mantenimientoLabel";
            fecha_mantenimientoLabel.Size = new System.Drawing.Size(127, 13);
            fecha_mantenimientoLabel.TabIndex = 9;
            fecha_mantenimientoLabel.Text = "Fecha de Mantenimiento:";
            // 
            // fecha_mantenimientoDateTimePicker
            // 
            this.fecha_mantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "fecha_mantenimiento", true));
            this.fecha_mantenimientoDateTimePicker.Location = new System.Drawing.Point(312, 180);
            this.fecha_mantenimientoDateTimePicker.Name = "fecha_mantenimientoDateTimePicker";
            this.fecha_mantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_mantenimientoDateTimePicker.TabIndex = 10;
            // 
            // tiempo_usoLabel
            // 
            tiempo_usoLabel.AutoSize = true;
            tiempo_usoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tiempo_usoLabel.Location = new System.Drawing.Point(179, 209);
            tiempo_usoLabel.Name = "tiempo_usoLabel";
            tiempo_usoLabel.Size = new System.Drawing.Size(80, 13);
            tiempo_usoLabel.TabIndex = 11;
            tiempo_usoLabel.Text = "Tiempo de uso:";
            // 
            // tiempo_usoTextBox
            // 
            this.tiempo_usoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "tiempo_uso", true));
            this.tiempo_usoTextBox.Location = new System.Drawing.Point(312, 206);
            this.tiempo_usoTextBox.Name = "tiempo_usoTextBox";
            this.tiempo_usoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tiempo_usoTextBox.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // mantenimientoBindingNavigatorSaveItem
            // 
            this.mantenimientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mantenimientoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBindingNavigatorSaveItem.Image")));
            this.mantenimientoBindingNavigatorSaveItem.Name = "mantenimientoBindingNavigatorSaveItem";
            this.mantenimientoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mantenimientoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.mantenimientoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mantenimientoBindingNavigatorSaveItem_Click);
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idMantenimientoLabel);
            this.Controls.Add(this.idMantenimientoTextBox);
            this.Controls.Add(estado_bandaLabel);
            this.Controls.Add(this.estado_bandaTextBox);
            this.Controls.Add(kilometrajeLabel);
            this.Controls.Add(this.kilometrajeTextBox);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOTextBox);
            this.Controls.Add(fecha_mantenimientoLabel);
            this.Controls.Add(this.fecha_mantenimientoDateTimePicker);
            this.Controls.Add(tiempo_usoLabel);
            this.Controls.Add(this.tiempo_usoTextBox);
            this.Controls.Add(this.mantenimientoBindingNavigator);
            this.Name = "FormMantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).EndInit();
            this.mantenimientoBindingNavigator.ResumeLayout(false);
            this.mantenimientoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private DataSetVehiculoTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mantenimientoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mantenimientoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idMantenimientoTextBox;
        private System.Windows.Forms.TextBox estado_bandaTextBox;
        private System.Windows.Forms.TextBox kilometrajeTextBox;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.DateTimePicker fecha_mantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox tiempo_usoTextBox;
    }
}