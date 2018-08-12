using WindowsFormsApplication1;
namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    partial class dataVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataVehiculo));
            //this.sistemaAAPDataSet = new MODULO_VEHICULO.sistemaAAPDataSet();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.vEHICULOTableAdapter = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter();
            //this.tableAdapterManager = new MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager();
            this.vEHICULOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vEHICULODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).BeginInit();
            this.vEHICULOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaAAPDataSet
            // 
            //this.sistemaAAPDataSet.DataSetName = "sistemaAAPDataSet";
            //this.sistemaAAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CHOFERTableAdapter = null;
            //this.tableAdapterManager.DisponibilidadVehiculoTableAdapter = null;
            //this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            //this.tableAdapterManager.incidenciaTableAdapter = null;
            //this.tableAdapterManager.IncidenciaVehiculoTableAdapter = null;
            // this.tableAdapterManager.LugarTableAdapter = null;
            //this.tableAdapterManager.MantenimientoTableAdapter = null;
            //this.tableAdapterManager.MotivoViajeTableAdapter = null;
            //this.tableAdapterManager.NominaProfesoresTableAdapter = null;
            //this.tableAdapterManager.NotificacionMantenimientoTableAdapter = null;
            //this.tableAdapterManager.NotificacionRutaTableAdapter = null;
            //this.tableAdapterManager.Reporte_ConductorTableAdapter = null;
            //this.tableAdapterManager.RESERVAAPROBADATableAdapter = null;
            // this.tableAdapterManager.SolicitanteTableAdapter = null;
            // this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            // this.tableAdapterManager.UpdateOrder = MODULO_VEHICULO.sistemaAAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULOBindingNavigator
            // 
            this.vEHICULOBindingNavigator.AddNewItem = null;
            this.vEHICULOBindingNavigator.BindingSource = this.vEHICULOBindingSource;
            this.vEHICULOBindingNavigator.CountItem = null;
            this.vEHICULOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vEHICULOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem});
            this.vEHICULOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vEHICULOBindingNavigator.MoveFirstItem = null;
            this.vEHICULOBindingNavigator.MoveLastItem = null;
            this.vEHICULOBindingNavigator.MoveNextItem = null;
            this.vEHICULOBindingNavigator.MovePreviousItem = null;
            this.vEHICULOBindingNavigator.Name = "vEHICULOBindingNavigator";
            this.vEHICULOBindingNavigator.PositionItem = null;
            this.vEHICULOBindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.vEHICULOBindingNavigator.TabIndex = 0;
            this.vEHICULOBindingNavigator.Text = "bindingNavigator1";
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
            // vEHICULODataGridView
            // 
            this.vEHICULODataGridView.AllowUserToResizeColumns = false;
            this.vEHICULODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vEHICULODataGridView.AutoGenerateColumns = false;
            this.vEHICULODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vEHICULODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vEHICULODataGridView.DataSource = this.vEHICULOBindingSource;
            this.vEHICULODataGridView.Location = new System.Drawing.Point(12, 37);
            this.vEHICULODataGridView.Name = "vEHICULODataGridView";
            this.vEHICULODataGridView.Size = new System.Drawing.Size(511, 257);
            this.vEHICULODataGridView.TabIndex = 1;
            this.vEHICULODataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vEHICULODataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDVEHICULO";
            this.dataGridViewTextBoxColumn1.FillWeight = 260F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Vehiculo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPOVEHICULO";
            this.dataGridViewTextBoxColumn2.FillWeight = 260F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Vehiculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PLACAVEHICULO";
            this.dataGridViewTextBoxColumn3.FillWeight = 280F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Placa de Vehiculo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 280;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn4.FillWeight = 260F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 260;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numeroPasajeros";
            this.dataGridViewTextBoxColumn5.FillWeight = 220F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Numero de Pasajeros";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // dataVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.vEHICULODataGridView);
            this.Controls.Add(this.vEHICULOBindingNavigator);
            this.Name = "dataVehiculo";
            this.Text = "dataVehiculo";
            this.Load += new System.EventHandler(this.dataVehiculo_Load);
            //((System.ComponentModel.ISupportInitialize)(this.sistemaAAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingNavigator)).EndInit();
            this.vEHICULOBindingNavigator.ResumeLayout(false);
            this.vEHICULOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private sistemaAAPDataSet sistemaAAPDataSet;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        // private sistemaAAPDataSetTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        // private sistemaAAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vEHICULOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridView vEHICULODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}