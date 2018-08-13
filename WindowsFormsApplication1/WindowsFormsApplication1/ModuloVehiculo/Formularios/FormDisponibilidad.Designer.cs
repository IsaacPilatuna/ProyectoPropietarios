namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class FormDisponibilidad
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
            System.Windows.Forms.Label idDisponibilidadVehiculoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label fecha_inicioLabel;
            System.Windows.Forms.Label fecha_finLabel;
            System.Windows.Forms.Label estado_vehiculoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisponibilidad));
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.disponibilidadVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disponibilidadVehiculoTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.DisponibilidadVehiculoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.disponibilidadVehiculoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disponibilidadVehiculoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDisponibilidadVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.fecha_inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_finDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estado_vehiculoTextBox = new System.Windows.Forms.TextBox();
            idDisponibilidadVehiculoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            fecha_inicioLabel = new System.Windows.Forms.Label();
            fecha_finLabel = new System.Windows.Forms.Label();
            estado_vehiculoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingNavigator)).BeginInit();
            this.disponibilidadVehiculoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idDisponibilidadVehiculoLabel
            // 
            idDisponibilidadVehiculoLabel.AutoSize = true;
            idDisponibilidadVehiculoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idDisponibilidadVehiculoLabel.Location = new System.Drawing.Point(158, 41);
            idDisponibilidadVehiculoLabel.Name = "idDisponibilidadVehiculoLabel";
            idDisponibilidadVehiculoLabel.Size = new System.Drawing.Size(133, 13);
            idDisponibilidadVehiculoLabel.TabIndex = 1;
            idDisponibilidadVehiculoLabel.Text = "ID Disponibilidad Vehiculo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descripcionLabel.Location = new System.Drawing.Point(158, 67);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            iDVEHICULOLabel.Location = new System.Drawing.Point(158, 93);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(65, 13);
            iDVEHICULOLabel.TabIndex = 5;
            iDVEHICULOLabel.Text = "ID Vehiculo:";
            // 
            // fecha_inicioLabel
            // 
            fecha_inicioLabel.AutoSize = true;
            fecha_inicioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fecha_inicioLabel.Location = new System.Drawing.Point(158, 120);
            fecha_inicioLabel.Name = "fecha_inicioLabel";
            fecha_inicioLabel.Size = new System.Drawing.Size(68, 13);
            fecha_inicioLabel.TabIndex = 7;
            fecha_inicioLabel.Text = "Fecha Inicio:";
            // 
            // fecha_finLabel
            // 
            fecha_finLabel.AutoSize = true;
            fecha_finLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fecha_finLabel.Location = new System.Drawing.Point(158, 146);
            fecha_finLabel.Name = "fecha_finLabel";
            fecha_finLabel.Size = new System.Drawing.Size(54, 13);
            fecha_finLabel.TabIndex = 9;
            fecha_finLabel.Text = "Fecha Fin";
            // 
            // estado_vehiculoLabel
            // 
            estado_vehiculoLabel.AutoSize = true;
            estado_vehiculoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            estado_vehiculoLabel.Location = new System.Drawing.Point(158, 171);
            estado_vehiculoLabel.Name = "estado_vehiculoLabel";
            estado_vehiculoLabel.Size = new System.Drawing.Size(87, 13);
            estado_vehiculoLabel.TabIndex = 11;
            estado_vehiculoLabel.Text = "Estado Vehiculo:";
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disponibilidadVehiculoBindingSource
            // 
            this.disponibilidadVehiculoBindingSource.DataMember = "DisponibilidadVehiculo";
            this.disponibilidadVehiculoBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // disponibilidadVehiculoTableAdapter
            // 
            this.disponibilidadVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calificacion_ServicioTableAdapter = null;
            this.tableAdapterManager.CargosTableAdapter = null;
            this.tableAdapterManager.CHOFERTableAdapter = null;
            this.tableAdapterManager.CuentaTableAdapter = null;
            this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = this.disponibilidadVehiculoTableAdapter;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.MotivoViajeTableAdapter = null;
            this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // disponibilidadVehiculoBindingNavigator
            // 
            this.disponibilidadVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disponibilidadVehiculoBindingNavigator.BackColor = System.Drawing.SystemColors.Highlight;
            this.disponibilidadVehiculoBindingNavigator.BindingSource = this.disponibilidadVehiculoBindingSource;
            this.disponibilidadVehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disponibilidadVehiculoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disponibilidadVehiculoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.disponibilidadVehiculoBindingNavigatorSaveItem});
            this.disponibilidadVehiculoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disponibilidadVehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disponibilidadVehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disponibilidadVehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disponibilidadVehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disponibilidadVehiculoBindingNavigator.Name = "disponibilidadVehiculoBindingNavigator";
            this.disponibilidadVehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disponibilidadVehiculoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.disponibilidadVehiculoBindingNavigator.TabIndex = 0;
            this.disponibilidadVehiculoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // disponibilidadVehiculoBindingNavigatorSaveItem
            // 
            this.disponibilidadVehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disponibilidadVehiculoBindingNavigatorSaveItem.Image")));
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Name = "disponibilidadVehiculoBindingNavigatorSaveItem";
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Click += new System.EventHandler(this.disponibilidadVehiculoBindingNavigatorSaveItem_Click);
            // 
            // idDisponibilidadVehiculoTextBox
            // 
            this.idDisponibilidadVehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "idDisponibilidadVehiculo", true));
            this.idDisponibilidadVehiculoTextBox.Location = new System.Drawing.Point(294, 38);
            this.idDisponibilidadVehiculoTextBox.Name = "idDisponibilidadVehiculoTextBox";
            this.idDisponibilidadVehiculoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDisponibilidadVehiculoTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(294, 64);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(294, 90);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDVEHICULOTextBox.TabIndex = 6;
            // 
            // fecha_inicioDateTimePicker
            // 
            this.fecha_inicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.disponibilidadVehiculoBindingSource, "fecha_inicio", true));
            this.fecha_inicioDateTimePicker.Location = new System.Drawing.Point(294, 116);
            this.fecha_inicioDateTimePicker.Name = "fecha_inicioDateTimePicker";
            this.fecha_inicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_inicioDateTimePicker.TabIndex = 8;
            // 
            // fecha_finDateTimePicker
            // 
            this.fecha_finDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.disponibilidadVehiculoBindingSource, "fecha_fin", true));
            this.fecha_finDateTimePicker.Location = new System.Drawing.Point(294, 142);
            this.fecha_finDateTimePicker.Name = "fecha_finDateTimePicker";
            this.fecha_finDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_finDateTimePicker.TabIndex = 10;
            // 
            // estado_vehiculoTextBox
            // 
            this.estado_vehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "estado_vehiculo", true));
            this.estado_vehiculoTextBox.Location = new System.Drawing.Point(294, 168);
            this.estado_vehiculoTextBox.Name = "estado_vehiculoTextBox";
            this.estado_vehiculoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estado_vehiculoTextBox.TabIndex = 12;
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idDisponibilidadVehiculoLabel);
            this.Controls.Add(this.idDisponibilidadVehiculoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOTextBox);
            this.Controls.Add(fecha_inicioLabel);
            this.Controls.Add(this.fecha_inicioDateTimePicker);
            this.Controls.Add(fecha_finLabel);
            this.Controls.Add(this.fecha_finDateTimePicker);
            this.Controls.Add(estado_vehiculoLabel);
            this.Controls.Add(this.estado_vehiculoTextBox);
            this.Controls.Add(this.disponibilidadVehiculoBindingNavigator);
            this.Name = "FormDisponibilidad";
            this.Text = "Disponibilidad";
            this.Load += new System.EventHandler(this.FormDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingNavigator)).EndInit();
            this.disponibilidadVehiculoBindingNavigator.ResumeLayout(false);
            this.disponibilidadVehiculoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource disponibilidadVehiculoBindingSource;
        private DataSetVehiculoTableAdapters.DisponibilidadVehiculoTableAdapter disponibilidadVehiculoTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disponibilidadVehiculoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton disponibilidadVehiculoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idDisponibilidadVehiculoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.DateTimePicker fecha_inicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_finDateTimePicker;
        private System.Windows.Forms.TextBox estado_vehiculoTextBox;
    }
}