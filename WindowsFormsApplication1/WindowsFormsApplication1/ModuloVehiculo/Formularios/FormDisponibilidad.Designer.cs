using WindowsFormsApplication1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisponibilidad));
            System.Windows.Forms.Label idDisponibilidadVehiculoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label fecha_finLabel;
            System.Windows.Forms.Label fecha_mantenimientoLabel;
            // this.sistemaAAPDataSet = new MODULO_VEHICULO.sistemaAAPDataSet();
            this.disponibilidadVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // this.disponibilidadVehiculoTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.DisponibilidadVehiculoTableAdapter();
            // this.tableAdapterManager = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager();
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
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // this.vEHICULOTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // this.mantenimientoTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter();
            this.idDisponibilidadVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.fecha_finDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_mantenimientoComboBox = new System.Windows.Forms.ComboBox();
            idDisponibilidadVehiculoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            fecha_finLabel = new System.Windows.Forms.Label();
            fecha_mantenimientoLabel = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingNavigator)).BeginInit();
            this.disponibilidadVehiculoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaAAPDataSet
            // 
            // this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            // this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disponibilidadVehiculoBindingSource
            // 
            this.disponibilidadVehiculoBindingSource.DataMember = "DisponibilidadVehiculo";
            //this.disponibilidadVehiculoBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // disponibilidadVehiculoTableAdapter
            // 
            //this.disponibilidadVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CHOFERTableAdapter = null;
            //this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = this.disponibilidadVehiculoTableAdapter;
            //this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            // this.tableAdapterManager.incidenciaTableAdapter = null;
            //this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            // this.tableAdapterManager.LugarTableAdapter = null;
            //this.tableAdapterManager.MantenimientoTableAdapter = null;
            //this.tableAdapterManager.MotivoViajeTableAdapter = null;
            //this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            //this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            // this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            //this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            //this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            //this.tableAdapterManager.SolicitanteTableAdapter = null;
            // this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            // this.tableAdapterManager.UpdateOrder = MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // disponibilidadVehiculoBindingNavigator
            // 
            this.disponibilidadVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            // disponibilidadVehiculoBindingNavigatorSaveItem
            // 
            this.disponibilidadVehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disponibilidadVehiculoBindingNavigatorSaveItem.Image")));
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Name = "disponibilidadVehiculoBindingNavigatorSaveItem";
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.disponibilidadVehiculoBindingNavigatorSaveItem.Click += new System.EventHandler(this.disponibilidadVehiculoBindingNavigatorSaveItem_Click);
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            // this.vEHICULOBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // vEHICULOTableAdapter
            // 
            //this.vEHICULOTableAdapter.ClearBeforeFill = true;
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
            // idDisponibilidadVehiculoLabel
            // 
            idDisponibilidadVehiculoLabel.AutoSize = true;
            idDisponibilidadVehiculoLabel.Location = new System.Drawing.Point(203, 118);
            idDisponibilidadVehiculoLabel.Name = "idDisponibilidadVehiculoLabel";
            idDisponibilidadVehiculoLabel.Size = new System.Drawing.Size(130, 13);
            idDisponibilidadVehiculoLabel.TabIndex = 1;
            idDisponibilidadVehiculoLabel.Text = "id Disponibilidad Vehiculo:";
            // 
            // idDisponibilidadVehiculoTextBox
            // 
            this.idDisponibilidadVehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "idDisponibilidadVehiculo", true));
            this.idDisponibilidadVehiculoTextBox.Location = new System.Drawing.Point(339, 115);
            this.idDisponibilidadVehiculoTextBox.Name = "idDisponibilidadVehiculoTextBox";
            this.idDisponibilidadVehiculoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDisponibilidadVehiculoTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(203, 144);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(339, 141);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.Location = new System.Drawing.Point(203, 170);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(75, 13);
            iDVEHICULOLabel.TabIndex = 5;
            iDVEHICULOLabel.Text = "IDVEHICULO:";
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disponibilidadVehiculoBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(339, 167);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDVEHICULOTextBox.TabIndex = 6;
            // 
            // fecha_finLabel
            // 
            fecha_finLabel.AutoSize = true;
            fecha_finLabel.Location = new System.Drawing.Point(203, 223);
            fecha_finLabel.Name = "fecha_finLabel";
            fecha_finLabel.Size = new System.Drawing.Size(51, 13);
            fecha_finLabel.TabIndex = 9;
            fecha_finLabel.Text = "fecha fin:";
            // 
            // fecha_finDateTimePicker
            // 
            this.fecha_finDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.disponibilidadVehiculoBindingSource, "fecha_fin", true));
            this.fecha_finDateTimePicker.Location = new System.Drawing.Point(339, 219);
            this.fecha_finDateTimePicker.Name = "fecha_finDateTimePicker";
            this.fecha_finDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_finDateTimePicker.TabIndex = 10;
            // 
            // fecha_mantenimientoLabel
            // 
            fecha_mantenimientoLabel.AutoSize = true;
            fecha_mantenimientoLabel.Location = new System.Drawing.Point(203, 200);
            fecha_mantenimientoLabel.Name = "fecha_mantenimientoLabel";
            fecha_mantenimientoLabel.Size = new System.Drawing.Size(108, 13);
            fecha_mantenimientoLabel.TabIndex = 10;
            fecha_mantenimientoLabel.Text = "fecha mantenimiento:";
            // 
            // fecha_mantenimientoComboBox
            // 
            this.fecha_mantenimientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "fecha_mantenimiento", true));
            this.fecha_mantenimientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.disponibilidadVehiculoBindingSource, "fecha_inicio", true));
            this.fecha_mantenimientoComboBox.DataSource = this.mantenimientoBindingSource;
            this.fecha_mantenimientoComboBox.DisplayMember = "fecha_mantenimiento";
            this.fecha_mantenimientoComboBox.FormattingEnabled = true;
            this.fecha_mantenimientoComboBox.Location = new System.Drawing.Point(339, 192);
            this.fecha_mantenimientoComboBox.Name = "fecha_mantenimientoComboBox";
            this.fecha_mantenimientoComboBox.Size = new System.Drawing.Size(200, 21);
            this.fecha_mantenimientoComboBox.TabIndex = 11;
            this.fecha_mantenimientoComboBox.ValueMember = "fecha_mantenimiento";
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(fecha_mantenimientoLabel);
            this.Controls.Add(this.fecha_mantenimientoComboBox);
            this.Controls.Add(idDisponibilidadVehiculoLabel);
            this.Controls.Add(this.idDisponibilidadVehiculoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOTextBox);
            this.Controls.Add(fecha_finLabel);
            this.Controls.Add(this.fecha_finDateTimePicker);
            this.Controls.Add(this.disponibilidadVehiculoBindingNavigator);
            this.Name = "FormDisponibilidad";
            this.Text = "FormDisponibilidad";
            this.Load += new System.EventHandler(this.FormDisponibilidad_Load);
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadVehiculoBindingNavigator)).EndInit();
            this.disponibilidadVehiculoBindingNavigator.ResumeLayout(false);
            this.disponibilidadVehiculoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource disponibilidadVehiculoBindingSource;
        // private sistemaAAPDataSetTableAdapters.DisponibilidadVehiculoTableAdapter disponibilidadVehiculoTableAdapter;
        //private sistemaAAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        //private sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        //private sistemaAAPDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private System.Windows.Forms.TextBox idDisponibilidadVehiculoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.DateTimePicker fecha_finDateTimePicker;
        private System.Windows.Forms.ComboBox fecha_mantenimientoComboBox;
    }
}