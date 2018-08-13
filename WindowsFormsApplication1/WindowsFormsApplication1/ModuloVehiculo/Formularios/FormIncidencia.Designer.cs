namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class FormIncidencia
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
            System.Windows.Forms.Label idIncidenciaVehiculoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncidencia));
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.incidenciaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciaVehiculoTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.IncidenciaVehiculoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.incidenciaVehiculoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.incidenciaVehiculoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idIncidenciaVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idIncidenciaVehiculoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingNavigator)).BeginInit();
            this.incidenciaVehiculoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idIncidenciaVehiculoLabel
            // 
            idIncidenciaVehiculoLabel.AutoSize = true;
            idIncidenciaVehiculoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idIncidenciaVehiculoLabel.Location = new System.Drawing.Point(145, 41);
            idIncidenciaVehiculoLabel.Name = "idIncidenciaVehiculoLabel";
            idIncidenciaVehiculoLabel.Size = new System.Drawing.Size(117, 13);
            idIncidenciaVehiculoLabel.TabIndex = 1;
            idIncidenciaVehiculoLabel.Text = "ID Incidencia Vehiculo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descripcionLabel.Location = new System.Drawing.Point(145, 67);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            iDVEHICULOLabel.Location = new System.Drawing.Point(145, 93);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(65, 13);
            iDVEHICULOLabel.TabIndex = 5;
            iDVEHICULOLabel.Text = "ID Vehiculo:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            horaLabel.Location = new System.Drawing.Point(145, 119);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 7;
            horaLabel.Text = "Hora:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fechaLabel.Location = new System.Drawing.Point(145, 146);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciaVehiculoBindingSource
            // 
            this.incidenciaVehiculoBindingSource.DataMember = "IncidenciaVehiculo";
            this.incidenciaVehiculoBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // incidenciaVehiculoTableAdapter
            // 
            this.incidenciaVehiculoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.IncidenciaVehiculoTableAdapter = this.incidenciaVehiculoTableAdapter;
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
            // incidenciaVehiculoBindingNavigator
            // 
            this.incidenciaVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.incidenciaVehiculoBindingNavigator.BackColor = System.Drawing.SystemColors.Highlight;
            this.incidenciaVehiculoBindingNavigator.BindingSource = this.incidenciaVehiculoBindingSource;
            this.incidenciaVehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incidenciaVehiculoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incidenciaVehiculoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.incidenciaVehiculoBindingNavigatorSaveItem});
            this.incidenciaVehiculoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incidenciaVehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.incidenciaVehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.incidenciaVehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.incidenciaVehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.incidenciaVehiculoBindingNavigator.Name = "incidenciaVehiculoBindingNavigator";
            this.incidenciaVehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incidenciaVehiculoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.incidenciaVehiculoBindingNavigator.TabIndex = 0;
            this.incidenciaVehiculoBindingNavigator.Text = "bindingNavigator1";
            this.incidenciaVehiculoBindingNavigator.RefreshItems += new System.EventHandler(this.incidenciaVehiculoBindingNavigator_RefreshItems);
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
            // incidenciaVehiculoBindingNavigatorSaveItem
            // 
            this.incidenciaVehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incidenciaVehiculoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incidenciaVehiculoBindingNavigatorSaveItem.Image")));
            this.incidenciaVehiculoBindingNavigatorSaveItem.Name = "incidenciaVehiculoBindingNavigatorSaveItem";
            this.incidenciaVehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.incidenciaVehiculoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.incidenciaVehiculoBindingNavigatorSaveItem.Click += new System.EventHandler(this.incidenciaVehiculoBindingNavigatorSaveItem_Click);
            // 
            // idIncidenciaVehiculoTextBox
            // 
            this.idIncidenciaVehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "idIncidenciaVehiculo", true));
            this.idIncidenciaVehiculoTextBox.Location = new System.Drawing.Point(265, 38);
            this.idIncidenciaVehiculoTextBox.Name = "idIncidenciaVehiculoTextBox";
            this.idIncidenciaVehiculoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idIncidenciaVehiculoTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(265, 64);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(265, 90);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDVEHICULOTextBox.TabIndex = 6;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(265, 116);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 8;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciaVehiculoBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(265, 142);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // FormIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idIncidenciaVehiculoLabel);
            this.Controls.Add(this.idIncidenciaVehiculoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.incidenciaVehiculoBindingNavigator);
            this.Name = "FormIncidencia";
            this.Text = "Incidencia";
            this.Load += new System.EventHandler(this.FormIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingNavigator)).EndInit();
            this.incidenciaVehiculoBindingNavigator.ResumeLayout(false);
            this.incidenciaVehiculoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource incidenciaVehiculoBindingSource;
        private DataSetVehiculoTableAdapters.IncidenciaVehiculoTableAdapter incidenciaVehiculoTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incidenciaVehiculoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton incidenciaVehiculoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idIncidenciaVehiculoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}