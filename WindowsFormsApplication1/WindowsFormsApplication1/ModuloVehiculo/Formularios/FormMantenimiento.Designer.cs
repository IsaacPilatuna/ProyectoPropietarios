using WindowsFormsApplication1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimiento));
            System.Windows.Forms.Label idMantenimientoLabel;
            System.Windows.Forms.Label estado_bandaLabel;
            System.Windows.Forms.Label fecha_mantenimientoLabel;
            System.Windows.Forms.Label tiempo_usoLabel;
            System.Windows.Forms.Label kilometrajeLabel;
            System.Windows.Forms.Label idVehiculoLabel;
            // this.sistemaAAPDataSet = new MODULO_VEHICULO.sistemaAAPDataSet();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // this.mantenimientoTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter();
            //this.tableAdapterManager = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager();
            this.mantenimientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.historialKilometrajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.historialKilometrajeTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.HistorialKilometrajeTableAdapter();
            this.idMantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.estado_bandaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_mantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tiempo_usoTextBox = new System.Windows.Forms.TextBox();
            this.kilometrajeComboBox = new System.Windows.Forms.ComboBox();
            this.idVehiculoComboBox = new System.Windows.Forms.ComboBox();
            idMantenimientoLabel = new System.Windows.Forms.Label();
            estado_bandaLabel = new System.Windows.Forms.Label();
            fecha_mantenimientoLabel = new System.Windows.Forms.Label();
            tiempo_usoLabel = new System.Windows.Forms.Label();
            kilometrajeLabel = new System.Windows.Forms.Label();
            idVehiculoLabel = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).BeginInit();
            this.mantenimientoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaAAPDataSet
            // 
            //this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            //this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            //this.mantenimientoBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // mantenimientoTableAdapter
            // 
            //this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CHOFERTableAdapter = null;
            //this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            //this.tableAdapterManager.HistorialKilometrajeTableAdapter = this.historialKilometrajeTableAdapter;
            //this.tableAdapterManager.incidenciaTableAdapter = null;
            //this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            //this.tableAdapterManager.LugarTableAdapter = null;
            //this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            //this.tableAdapterManager.MotivoViajeTableAdapter = null;
            //this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            //this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            //this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            //this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            //this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            //this.tableAdapterManager.SolicitanteTableAdapter = null;
            //this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            //this.tableAdapterManager.UpdateOrder = MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // mantenimientoBindingNavigator
            // 
            this.mantenimientoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // historialKilometrajeBindingSource
            // 
            this.historialKilometrajeBindingSource.DataMember = "HistorialKilometraje";
            //this.historialKilometrajeBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // historialKilometrajeTableAdapter
            // 
            //this.historialKilometrajeTableAdapter.ClearBeforeFill = true;
            // 
            // idMantenimientoLabel
            // 
            idMantenimientoLabel.AutoSize = true;
            idMantenimientoLabel.Location = new System.Drawing.Point(207, 143);
            idMantenimientoLabel.Name = "idMantenimientoLabel";
            idMantenimientoLabel.Size = new System.Drawing.Size(90, 13);
            idMantenimientoLabel.TabIndex = 1;
            idMantenimientoLabel.Text = "id Mantenimiento:";
            // 
            // idMantenimientoTextBox
            // 
            this.idMantenimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "idMantenimiento", true));
            this.idMantenimientoTextBox.Location = new System.Drawing.Point(321, 140);
            this.idMantenimientoTextBox.Name = "idMantenimientoTextBox";
            this.idMantenimientoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idMantenimientoTextBox.TabIndex = 2;
            // 
            // estado_bandaLabel
            // 
            estado_bandaLabel.AutoSize = true;
            estado_bandaLabel.Location = new System.Drawing.Point(207, 169);
            estado_bandaLabel.Name = "estado_bandaLabel";
            estado_bandaLabel.Size = new System.Drawing.Size(75, 13);
            estado_bandaLabel.TabIndex = 3;
            estado_bandaLabel.Text = "estado banda:";
            // 
            // estado_bandaTextBox
            // 
            this.estado_bandaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "estado_banda", true));
            this.estado_bandaTextBox.Location = new System.Drawing.Point(321, 166);
            this.estado_bandaTextBox.Name = "estado_bandaTextBox";
            this.estado_bandaTextBox.Size = new System.Drawing.Size(200, 20);
            this.estado_bandaTextBox.TabIndex = 4;
            // 
            // fecha_mantenimientoLabel
            // 
            fecha_mantenimientoLabel.AutoSize = true;
            fecha_mantenimientoLabel.Location = new System.Drawing.Point(207, 248);
            fecha_mantenimientoLabel.Name = "fecha_mantenimientoLabel";
            fecha_mantenimientoLabel.Size = new System.Drawing.Size(108, 13);
            fecha_mantenimientoLabel.TabIndex = 9;
            fecha_mantenimientoLabel.Text = "fecha mantenimiento:";
            // 
            // fecha_mantenimientoDateTimePicker
            // 
            this.fecha_mantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "fecha_mantenimiento", true));
            this.fecha_mantenimientoDateTimePicker.Location = new System.Drawing.Point(321, 244);
            this.fecha_mantenimientoDateTimePicker.Name = "fecha_mantenimientoDateTimePicker";
            this.fecha_mantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_mantenimientoDateTimePicker.TabIndex = 10;
            // 
            // tiempo_usoLabel
            // 
            tiempo_usoLabel.AutoSize = true;
            tiempo_usoLabel.Location = new System.Drawing.Point(207, 273);
            tiempo_usoLabel.Name = "tiempo_usoLabel";
            tiempo_usoLabel.Size = new System.Drawing.Size(61, 13);
            tiempo_usoLabel.TabIndex = 11;
            tiempo_usoLabel.Text = "tiempo uso:";
            // 
            // tiempo_usoTextBox
            // 
            this.tiempo_usoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "tiempo_uso", true));
            this.tiempo_usoTextBox.Location = new System.Drawing.Point(321, 270);
            this.tiempo_usoTextBox.Name = "tiempo_usoTextBox";
            this.tiempo_usoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tiempo_usoTextBox.TabIndex = 12;
            // 
            // kilometrajeLabel
            // 
            kilometrajeLabel.AutoSize = true;
            kilometrajeLabel.Location = new System.Drawing.Point(211, 195);
            kilometrajeLabel.Name = "kilometrajeLabel";
            kilometrajeLabel.Size = new System.Drawing.Size(60, 13);
            kilometrajeLabel.TabIndex = 12;
            kilometrajeLabel.Text = "kilometraje:";
            // 
            // kilometrajeComboBox
            // 
            this.kilometrajeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialKilometrajeBindingSource, "kilometraje", true));
            this.kilometrajeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mantenimientoBindingSource, "kilometraje", true));
            this.kilometrajeComboBox.DataSource = this.historialKilometrajeBindingSource;
            this.kilometrajeComboBox.DisplayMember = "kilometraje";
            this.kilometrajeComboBox.FormattingEnabled = true;
            this.kilometrajeComboBox.Location = new System.Drawing.Point(321, 192);
            this.kilometrajeComboBox.Name = "kilometrajeComboBox";
            this.kilometrajeComboBox.Size = new System.Drawing.Size(200, 21);
            this.kilometrajeComboBox.TabIndex = 13;
            this.kilometrajeComboBox.ValueMember = "idHistorial";
            this.kilometrajeComboBox.SelectedIndexChanged += new System.EventHandler(this.kilometrajeComboBox_SelectedIndexChanged);
            // 
            // idVehiculoLabel
            // 
            idVehiculoLabel.AutoSize = true;
            idVehiculoLabel.Location = new System.Drawing.Point(211, 230);
            idVehiculoLabel.Name = "idVehiculoLabel";
            idVehiculoLabel.Size = new System.Drawing.Size(62, 13);
            idVehiculoLabel.TabIndex = 13;
            idVehiculoLabel.Text = "id Vehiculo:";
            idVehiculoLabel.Click += new System.EventHandler(this.idVehiculoLabel_Click_1);
            // 
            // idVehiculoComboBox
            // 
            this.idVehiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialKilometrajeBindingSource, "idVehiculo", true));
            this.idVehiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mantenimientoBindingSource, "IDVEHICULO", true));
            this.idVehiculoComboBox.DataSource = this.historialKilometrajeBindingSource;
            this.idVehiculoComboBox.DisplayMember = "idVehiculo";
            this.idVehiculoComboBox.FormattingEnabled = true;
            this.idVehiculoComboBox.Location = new System.Drawing.Point(321, 219);
            this.idVehiculoComboBox.Name = "idVehiculoComboBox";
            this.idVehiculoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idVehiculoComboBox.TabIndex = 14;
            this.idVehiculoComboBox.ValueMember = "idVehiculo";
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idVehiculoLabel);
            this.Controls.Add(this.idVehiculoComboBox);
            this.Controls.Add(kilometrajeLabel);
            this.Controls.Add(this.kilometrajeComboBox);
            this.Controls.Add(idMantenimientoLabel);
            this.Controls.Add(this.idMantenimientoTextBox);
            this.Controls.Add(estado_bandaLabel);
            this.Controls.Add(this.estado_bandaTextBox);
            this.Controls.Add(fecha_mantenimientoLabel);
            this.Controls.Add(this.fecha_mantenimientoDateTimePicker);
            this.Controls.Add(tiempo_usoLabel);
            this.Controls.Add(this.tiempo_usoTextBox);
            this.Controls.Add(this.mantenimientoBindingNavigator);
            this.Name = "FormMantenimiento";
            this.Text = "FormMantenimiento";
            this.Load += new System.EventHandler(this.FormMantenimiento_Load);
            // ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).EndInit();
            this.mantenimientoBindingNavigator.ResumeLayout(false);
            this.mantenimientoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        // private sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        //private sistemaAAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        //private sistemaAAPDataSetTableAdapters.HistorialKilometrajeTableAdapter historialKilometrajeTableAdapter;
        private System.Windows.Forms.BindingSource historialKilometrajeBindingSource;
        private System.Windows.Forms.TextBox idMantenimientoTextBox;
        private System.Windows.Forms.TextBox estado_bandaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_mantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox tiempo_usoTextBox;
        private System.Windows.Forms.ComboBox kilometrajeComboBox;
        private System.Windows.Forms.ComboBox idVehiculoComboBox;
    }
}