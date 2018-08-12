using WindowsFormsApplication1;
namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            System.Windows.Forms.Label pLACAVEHICULOLabel;
            System.Windows.Forms.Label iDVEHICULOLabel;
            //this.sistemaAAPDataSet = new MODULO_VEHICULO.sistemaAAPDataSet();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // this.vEHICULOTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter();
            // this.tableAdapterManager = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager();
            this.vEHICULOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vEHICULOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pLACAVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            this.iDVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            pLACAVEHICULOLabel = new System.Windows.Forms.Label();
            iDVEHICULOLabel = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).BeginInit();
            this.vEHICULOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaAAPDataSet
            // 
            //this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            // this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            //this.vEHICULOBindingSource.DataSource = this.sistemaAAPDataSet;
            // 
            // vEHICULOTableAdapter
            // 
            //this.vEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CHOFERTableAdapter = null;
            //this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            //this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            //this.tableAdapterManager.incidenciaTableAdapter = null;
            //this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
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
            //this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULOBindingNavigator
            // 
            this.vEHICULOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            // vEHICULOBindingNavigatorSaveItem
            // 
            this.vEHICULOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vEHICULOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vEHICULOBindingNavigatorSaveItem.Image")));
            this.vEHICULOBindingNavigatorSaveItem.Name = "vEHICULOBindingNavigatorSaveItem";
            this.vEHICULOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vEHICULOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vEHICULOBindingNavigatorSaveItem.Click += new System.EventHandler(this.vEHICULOBindingNavigatorSaveItem_Click_1);
            // 
            // pLACAVEHICULOComboBox
            // 
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vEHICULOBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOComboBox.DataSource = this.vEHICULOBindingSource;
            this.pLACAVEHICULOComboBox.DisplayMember = "PLACAVEHICULO";
            this.pLACAVEHICULOComboBox.FormattingEnabled = true;
            this.pLACAVEHICULOComboBox.Location = new System.Drawing.Point(240, 93);
            this.pLACAVEHICULOComboBox.Name = "pLACAVEHICULOComboBox";
            this.pLACAVEHICULOComboBox.Size = new System.Drawing.Size(121, 21);
            this.pLACAVEHICULOComboBox.TabIndex = 2;
            this.pLACAVEHICULOComboBox.ValueMember = "PLACAVEHICULO";
            this.pLACAVEHICULOComboBox.SelectedIndexChanged += new System.EventHandler(this.pLACAVEHICULOComboBox_SelectedIndexChanged);
            // 
            // pLACAVEHICULOLabel
            // 
            pLACAVEHICULOLabel.AutoSize = true;
            pLACAVEHICULOLabel.Location = new System.Drawing.Point(136, 96);
            pLACAVEHICULOLabel.Name = "pLACAVEHICULOLabel";
            pLACAVEHICULOLabel.Size = new System.Drawing.Size(98, 13);
            pLACAVEHICULOLabel.TabIndex = 1;
            pLACAVEHICULOLabel.Text = "PLACAVEHICULO:";
            // 
            // iDVEHICULOComboBox
            // 
            this.iDVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "IDVEHICULO", true));
            this.iDVEHICULOComboBox.FormattingEnabled = true;
            this.iDVEHICULOComboBox.Location = new System.Drawing.Point(217, 128);
            this.iDVEHICULOComboBox.Name = "iDVEHICULOComboBox";
            this.iDVEHICULOComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDVEHICULOComboBox.TabIndex = 4;
            // 
            // iDVEHICULOLabel
            // 
            iDVEHICULOLabel.AutoSize = true;
            iDVEHICULOLabel.Location = new System.Drawing.Point(136, 131);
            iDVEHICULOLabel.Name = "iDVEHICULOLabel";
            iDVEHICULOLabel.Size = new System.Drawing.Size(75, 13);
            iDVEHICULOLabel.TabIndex = 3;
            iDVEHICULOLabel.Text = "IDVEHICULO:";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iDVEHICULOLabel);
            this.Controls.Add(this.iDVEHICULOComboBox);
            this.Controls.Add(pLACAVEHICULOLabel);
            this.Controls.Add(this.pLACAVEHICULOComboBox);
            this.Controls.Add(this.vEHICULOBindingNavigator);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            // ((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).EndInit();
            this.vEHICULOBindingNavigator.ResumeLayout(false);
            this.vEHICULOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        //private sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        //private sistemaAAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ComboBox pLACAVEHICULOComboBox;
        private System.Windows.Forms.ComboBox iDVEHICULOComboBox;
    }
}