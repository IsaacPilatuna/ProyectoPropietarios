
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    public partial class FormDatos : Form
    {

        Cuenta _cuenta = new Cuenta();


        public FormDatos()
        {
            InitializeComponent();
            //llenarCargo();
            this.cBcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //_usuario.Cedula = tBCedula.Text;
            //_usuario.Nombre = tBNombre.Text;
            //_usuario.Apellido = tBapellido.Text;
            //_usuario.Fecha_de_nacimiento = DateTime.Parse(tBfnacimiento.Text);
            //_usuario.Telefono = tBtelf.Text;
            //_usuario.Direccion = tBdir.Text;
            //_usuario.Email = tBcorreo.Text;

            //_cuenta.Cargo = cBcargo.SelectedIndex;
            //_cuenta.Contraseña = tBpass.Text;
            //_cuenta.Usuario = tBCedula.Text;
        }

        private void cBcargo_SelectedIndexChanged(object sender, EventArgs e)
        {


            //llenarCargo();

        }

        //public void llenarCargo()
        //{
        //    //se realiza la conexión a la base de datos
        //    Conexion conn = new Conexion();
        //    //conn.abrirConexion();
        //    //se inicia un DataSet
        //    DataSet dsd = new DataSet();
        //    //se indica la consulta en sql
        //    SqlDataAdapter dad = new SqlDataAdapter("Select * from Rol", conn.abrirConexion());
        //    //se indica con quu tabla se llena
        //    dad.Fill(dsd, "Rol");
        //    cBcargo.DataSource = dsd.Tables[0].DefaultView;
        //    //indicamos el valor de los miembros
        //    cBcargo.ValueMember = "Id";
        //    //se indica el valor a desplegar en el combobox
        //    cBcargo.DisplayMember = "nombre";
        //}
    }
}
