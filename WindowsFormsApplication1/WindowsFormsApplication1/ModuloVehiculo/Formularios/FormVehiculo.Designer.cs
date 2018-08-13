namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class FormVehiculo
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
            System.Windows.Forms.Label iDVEHICULOLabel;
            System.Windows.Forms.Label tIPOVEHICULOLabel;
            System.Windows.Forms.Label pLACAVEHICULOLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label numeroPasajerosLabel;
            System.Windows.Forms.Label anioVehiculoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculo));
            this.dataSetVehiculo = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculo();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULOTableAdapter = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.VEHICULOTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ModuloVehiculo.DataSetVehiculoTableAdapters.TableAdapterManager();
            this.vEHICULOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vEHICULOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.tIPOVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.pLACAVEHICULOTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.numeroPasajerosTextBox = new System.Windows.Forms.TextBox();
            this.anioVehiculoTextBox = new System.Windows.Forms.TextBox();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            tIPOVEHICULOLabel = new System.Windows.Forms.Label();
            pLACAVEHICULOLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            numeroPasajerosLabel = new System.Windows.Forms.Label();
            anioVehiculoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).BeginInit();
            this.vEHICULOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.Location = new System.Drawing.Point(205, 46);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(65, 13);
            iDVEHICULOLabel.TabIndex = 1;
            iDVEHICULOLabel.Text = "ID Vehiculo:";
            // 
            // tIPOVEHICULOLabel
            // 
            tIPOVEHICULOLabel.AutoSize = true;
            tIPOVEHICULOLabel.Location = new System.Drawing.Point(205, 72);
            tIPOVEHICULOLabel.Name = "tIPOVEHICULOLabel";
            tIPOVEHICULOLabel.Size = new System.Drawing.Size(90, 13);
            tIPOVEHICULOLabel.TabIndex = 3;
            tIPOVEHICULOLabel.Text = "Tipo de Vehiculo:";
            // 
            // pLACAVEHICULOLabel
            // 
            pLACAVEHICULOLabel.AutoSize = true;
            pLACAVEHICULOLabel.Location = new System.Drawing.Point(205, 98);
            pLACAVEHICULOLabel.Name = "pLACAVEHICULOLabel";
            pLACAVEHICULOLabel.Size = new System.Drawing.Size(96, 13);
            pLACAVEHICULOLabel.TabIndex = 5;
            pLACAVEHICULOLabel.Text = "Placa de Vehiculo:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(205, 124);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 7;
            matriculaLabel.Text = "Matricula:";
            // 
            // numeroPasajerosLabel
            // 
            numeroPasajerosLabel.AutoSize = true;
            numeroPasajerosLabel.Location = new System.Drawing.Point(205, 150);
            numeroPasajerosLabel.Name = "numeroPasajerosLabel";
            numeroPasajerosLabel.Size = new System.Drawing.Size(96, 13);
            numeroPasajerosLabel.TabIndex = 9;
            numeroPasajerosLabel.Text = "Número Pasajeros:";
            // 
            // anioVehiculoLabel
            // 
            anioVehiculoLabel.AutoSize = true;
            anioVehiculoLabel.Location = new System.Drawing.Point(205, 176);
            anioVehiculoLabel.Name = "anioVehiculoLabel";
            anioVehiculoLabel.Size = new System.Drawing.Size(90, 13);
            anioVehiculoLabel.TabIndex = 11;
            anioVehiculoLabel.Text = "Año del Vehiculo:";
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            this.vEHICULOBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // vEHICULOTableAdapter
            // 
            this.vEHICULOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULOBindingNavigator
            // 
            this.vEHICULOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vEHICULOBindingNavigator.BackColor = System.Drawing.SystemColors.Highlight;
            this.vEHICULOBindingNavigator.BindingSource = this.vEHICULOBindingSource;
            this.vEHICULOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vEHICULOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vEHICULOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vEHICULOBindingNavigatorSaveItem});
            this.vEHICULOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vEHICULOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vEHICULOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vEHICULOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vEHICULOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vEHICULOBindingNavigator.Name = "vEHICULOBindingNavigator";
            this.vEHICULOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vEHICULOBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.vEHICULOBindingNavigator.TabIndex = 0;
            this.vEHICULOBindingNavigator.Text = "bindingNavigator1";
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
            // vEHICULOBindingNavigatorSaveItem
            // 
            this.vEHICULOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vEHICULOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vEHICULOBindingNavigatorSaveItem.Image")));
            this.vEHICULOBindingNavigatorSaveItem.Name = "vEHICULOBindingNavigatorSaveItem";
            this.vEHICULOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vEHICULOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vEHICULOBindingNavigatorSaveItem.Click += new System.EventHandler(this.vEHICULOBindingNavigatorSaveItem_Click);
            // 
            // iDVEHICULOTextBox
            // 
            this.iDVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOTextBox.Location = new System.Drawing.Point(309, 43);
            this.iDVEHICULOTextBox.Name = "iDVEHICULOTextBox";
            this.iDVEHICULOTextBox.ReadOnly = true;
            this.iDVEHICULOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDVEHICULOTextBox.TabIndex = 2;
            // 
            // tIPOVEHICULOTextBox
            // 
            this.tIPOVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "TIPOVEHICULO", true));
            this.tIPOVEHICULOTextBox.Location = new System.Drawing.Point(309, 69);
            this.tIPOVEHICULOTextBox.Name = "tIPOVEHICULOTextBox";
            this.tIPOVEHICULOTextBox.Size = new System.Drawing.Size(100, 20);
            this.tIPOVEHICULOTextBox.TabIndex = 4;
            // 
            // pLACAVEHICULOTextBox
            // 
            this.pLACAVEHICULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOTextBox.Location = new System.Drawing.Point(309, 95);
            this.pLACAVEHICULOTextBox.Name = "pLACAVEHICULOTextBox";
            this.pLACAVEHICULOTextBox.Size = new System.Drawing.Size(100, 20);
            this.pLACAVEHICULOTextBox.TabIndex = 6;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(309, 121);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 8;
            // 
            // numeroPasajerosTextBox
            // 
            this.numeroPasajerosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "numeroPasajeros", true));
            this.numeroPasajerosTextBox.Location = new System.Drawing.Point(309, 147);
            this.numeroPasajerosTextBox.Name = "numeroPasajerosTextBox";
            this.numeroPasajerosTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroPasajerosTextBox.TabIndex = 10;
            // 
            // anioVehiculoTextBox
            // 
            this.anioVehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "anioVehiculo", true));
            this.anioVehiculoTextBox.Location = new System.Drawing.Point(309, 173);
            this.anioVehiculoTextBox.Name = "anioVehiculoTextBox";
            this.anioVehiculoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anioVehiculoTextBox.TabIndex = 12;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOTextBox);
            this.Controls.Add(tIPOVEHICULOLabel);
            this.Controls.Add(this.tIPOVEHICULOTextBox);
            this.Controls.Add(pLACAVEHICULOLabel);
            this.Controls.Add(this.pLACAVEHICULOTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(numeroPasajerosLabel);
            this.Controls.Add(this.numeroPasajerosTextBox);
            this.Controls.Add(anioVehiculoLabel);
            this.Controls.Add(this.anioVehiculoTextBox);
            this.Controls.Add(this.vEHICULOBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormVehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).EndInit();
            this.vEHICULOBindingNavigator.ResumeLayout(false);
            this.vEHICULOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private DataSetVehiculoTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private DataSetVehiculoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vEHICULOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vEHICULOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDVEHICULOTextBox;
        private System.Windows.Forms.TextBox tIPOVEHICULOTextBox;
        private System.Windows.Forms.TextBox pLACAVEHICULOTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox numeroPasajerosTextBox;
        private System.Windows.Forms.TextBox anioVehiculoTextBox;
    }
}