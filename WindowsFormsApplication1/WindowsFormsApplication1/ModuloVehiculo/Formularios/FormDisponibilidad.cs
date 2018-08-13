﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloVehiculo.Formularios
{
    public partial class FormDisponibilidad : Form
    {
        public FormDisponibilidad()
        {
            InitializeComponent();
        }

        private void disponibilidadVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disponibilidadVehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVehiculo);

        }

        private void FormDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.DisponibilidadVehiculo' Puede moverla o quitarla según sea necesario.
            this.disponibilidadVehiculoTableAdapter.Fill(this.dataSetVehiculo.DisponibilidadVehiculo);

        }
    }
}
