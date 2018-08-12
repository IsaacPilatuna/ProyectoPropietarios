using WindowsFormsApplication1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncidencia));
            System.Windows.Forms.Label idIncidenciaVehiculoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label fechaLabel;
            // this.sistemaAAPDataSet = new MODULO_VEHICULO.sistemaAAPDataSet();
            this.incidenciaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.incidenciaVehiculoTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.IncidenciaVehiculoTableAdapter();
            //this.tableAdapterManager = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager();
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
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAAPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAAPDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.vEHICULOTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter();
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
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingNavigator)).BeginInit();
            this.incidenciaVehiculoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaAAPDataSet
            // 
            //this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            //this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciaVehiculoBindingSource
            // 
            this.incidenciaVehiculoBindingSource.DataMember = "IncidenciaVehiculo";
            //this.incidenciaVehiculoBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // incidenciaVehiculoTableAdapter
            // 
            //this.incidenciaVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CHOFERTableAdapter = null;
            //this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            //this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            //this.tableAdapterManager.incidenciaTableAdapter = null;
            //this.tableAdapterManager.IncidenciaVehiculoTableAdapter = this.incidenciaVehiculoTableAdapter;
            //this.tableAdapterManager.LugarTableAdapter = null;
            //this.tableAdapterManager.MantenimientoTableAdapter = null;
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
            // incidenciaVehiculoBindingNavigator
            // 
            this.incidenciaVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            //this.vEHICULOBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // sistemaAAPDataSetBindingSource
            // 
            //this.sistemaAAPDataSetBindingSource.DataSource = this.sistemaAAPDataSet;
            this.sistemaAAPDataSetBindingSource.Position = 0;
            // 
            // sistemaAAPDataSetBindingSource1
            // 
            //this.sistemaAAPDataSetBindingSource1.DataSource = this.sistemaAAPDataSet;
            this.sistemaAAPDataSetBindingSource1.Position = 0;
            // 
            // vEHICULOTableAdapter
            // 
            //this.vEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // idIncidenciaVehiculoLabel
            // 
            idIncidenciaVehiculoLabel.AutoSize = true;
            idIncidenciaVehiculoLabel.Location = new System.Drawing.Point(217, 115);
            idIncidenciaVehiculoLabel.Name = "idIncidenciaVehiculoLabel";
            idIncidenciaVehiculoLabel.Size = new System.Drawing.Size(114, 13);
            idIncidenciaVehiculoLabel.TabIndex = 1;
            idIncidenciaVehiculoLabel.Text = "id Incidencia Vehiculo:";
            // 
            // idIncidenciaVehiculoTextBox
            // 
            this.idIncidenciaVehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "idIncidenciaVehiculo", true));
            this.idIncidenciaVehiculoTextBox.Location = new System.Drawing.Point(337, 112);
            this.idIncidenciaVehiculoTextBox.Name = "idIncidenciaVehiculoTextBox";
            this.idIncidenciaVehiculoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idIncidenciaVehiculoTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(217, 141);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(337, 138);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.Location = new System.Drawing.Point(217, 167);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(75, 13);
            iDVEHICULOLabel.TabIndex = 5;
            iDVEHICULOLabel.Text = "IDVEHICULO:";
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(337, 164);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDVEHICULOTextBox.TabIndex = 6;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(217, 193);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(31, 13);
            horaLabel.TabIndex = 7;
            horaLabel.Text = "hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaVehiculoBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(337, 190);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 8;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(217, 220);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciaVehiculoBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(337, 216);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // FormIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Text = "FormIncidencia_Vehiculocs";
            this.Load += new System.EventHandler(this.FormIncidencia_Vehiculocs_Load);
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaVehiculoBindingNavigator)).EndInit();
            this.incidenciaVehiculoBindingNavigator.ResumeLayout(false);
            this.incidenciaVehiculoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource incidenciaVehiculoBindingSource;
        //private sistemaAAPDataSetTableAdapters.IncidenciaVehiculoTableAdapter incidenciaVehiculoTableAdapter;
        //private sistemaAAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource sistemaAAPDataSetBindingSource1;
        private System.Windows.Forms.BindingSource sistemaAAPDataSetBindingSource;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        //private sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private System.Windows.Forms.TextBox idIncidenciaVehiculoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}