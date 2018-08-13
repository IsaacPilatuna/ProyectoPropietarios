using ModuloVehiculo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloVehiculo_Grupo7.Interfaz;

namespace ModuloVehiculo.Interfaz
{
    public partial class VehiculoFormulario : Form
    {
        private int valor;
        private ListaVehiculos lista= new ListaVehiculos();
        public VehiculoFormulario(int value)
        {
            InitializeComponent();
            this.valor = value;
            if (valor==1){
                btnHI.Visible = false;
                btnHM.Visible = false;
                btnModificar.Visible = false;
                btnImagenV.Enabled = true;
                trackBV.Visible = false;
                txtAno.Enabled = true;
                txtCapacidad.Enabled = true;
                txtMatricula.Enabled = true;
                txtPlaca.Enabled = true;
                cmbTipoV.Enabled = true;
            }
        }
        
        private void VehiculoFormulario_Load(object sender, EventArgs e)
        {
            trackBV.Maximum = lista.Longitud_Lista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            btnImagenV.Enabled = true;
            txtAno.Enabled = true;
            txtCapacidad.Enabled = true;
            txtMatricula.Enabled = true;
            txtPlaca.Enabled = true;
            cmbTipoV.Enabled = true;
            btnModificar.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(valor == 1)
            {
                if(verificarvacios()==0)
                {
                    Vehiculo vehiculo = new Vehiculo(Convert.ToString(txtPlaca.Text), Convert.ToString(txtMatricula.Text), Convert.ToString(cmbTipoV.SelectedItem), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtAno.Text));
                    vehiculo.Registrar_Vehiculo(placa: txtPlaca.Text, matricula: txtMatricula.Text, Tipo_V: Convert.ToString(cmbTipoV.SelectedItem), num_pasajeros: Convert.ToInt32(txtCapacidad.Text), anio: Convert.ToInt32(txtAno.Text));
                    FormularioIngresoIM frim = new FormularioIngresoIM();
                    DialogResult result =  MessageBox.Show("¿Quieres registrar un mantenimiento para este vehiculo?", "Mantenimiento", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        frim.Visible = true;
                        Limpiar();
                        VehiculoFormulario.ActiveForm.Visible = false;
                    }
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        MessageBox.Show("Registro existoso!!!");
                    }
                        
                }
            }
            else
            {
                Vehiculo VehMod = new Vehiculo(Convert.ToString(txtPlaca.Text), txtMatricula.Text.ToString(), cmbTipoV.SelectedItem.ToString(), int.Parse(txtCapacidad.Text), int.Parse(txtAno.Text));
                VehMod.Actualizar_Vehiculo("update VEHICULO  set TIPOVEHICULO = '" + VehMod.Gettipo_vehiculo().ToString() + "', PLACAVEHICULO='" + VehMod.Getplaca() + "',matricula='" + VehMod.Getmatricula() + "', numeroPasajeros=" + VehMod.Getnum_pasajero() + ",anioVehiculo=" + VehMod.Getanio() + " where IDVEHICULO=" + VehMod.Getid_vehiculo() + "");
                btnImagenV.Enabled = false;
                txtAno.Enabled = false;
                txtCapacidad.Enabled = false;
                txtMatricula.Enabled = false;
                txtPlaca.Enabled = false;
                cmbTipoV.Enabled = false;
                btnModificar.Visible = true;
            }
        }
        public int verificarvacios()
        {
            int contador = 0;
            string mss = "Error en el proceso, verifique que esten llenos los siguientes campos:";
            if (txtAno.Text.Equals(""))
            {
                contador++;
                mss += "\n- AÑO ";
            }
               
            if (txtCapacidad.Text.Equals(""))
            {
                contador++;
                mss += "\n- Capacidad ";
            }

            if (txtPlaca.Text.Equals(""))
            {
                contador++;
                mss += "\n- Placa ";
            }
            if (txtMatricula.Text.Equals(""))
            {
                contador++;
                mss += "\n- Matricula ";
            }
            if (btnImagenV.BackgroundImage==null)
            {
                contador++;
                mss += "\n- Imagen del Vehiculo ";
            }
            if (contador > 0)
                MessageBox.Show(mss);

            return contador;
        }
        private void Limpiar()
        {
            txtAno.Text = "";
            txtCapacidad.Text = "";
            txtMatricula.Text = "";
            txtPlaca.Text = "";
            cmbTipoV.SelectedIndex = -1;
            btnImagenV.BackgroundImage = null;
        }

        private void btnImagenV_Click(object sender, EventArgs e)
        {
            string direccion = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                direccion = openFileDialog1.FileName;
                Image img = Image.FromFile(direccion);
                btnImagenV.BackgroundImage = img;
                File.Copy(direccion, "C:\\Users\\Chris_informatico\\Source\\Repos\\ProyectoPropietarios\\WindowsFormsApplication1\\WindowsFormsApplication1\\ModuloVehiculo-Grupo7\\Icons\\"+txtPlaca.Text+".jpg");
                StreamWriter WriteReportFile = File.AppendText("C:\\Users\\Chris_informatico\\Source\\Repos\\ProyectoPropietarios\\WindowsFormsApplication1\\WindowsFormsApplication1\\ModuloVehiculo-Grupo7\\Icons\\Img.txt");
                WriteReportFile.WriteLine(txtPlaca.Text+ ";C:\\Users\\Chris_informatico\\Source\\Repos\\ProyectoPropietarios\\WindowsFormsApplication1\\WindowsFormsApplication1\\ModuloVehiculo-Grupo7\\Icons\\"+txtPlaca.Text+".jpg");
                WriteReportFile.Close();
            }
        }

        private void trackBV_Scroll(object sender, EventArgs e)
        {
            int cont = 0;
            
           foreach (Vehiculo v in lista.GetListaVehiculas())
            {
                if (cont == Convert.ToInt32(trackBV.Value))
                {
                    txtID.Text = Convert.ToString(v.Getid_vehiculo());
                    txtAno.Text = Convert.ToString(v.Getanio());
                    txtCapacidad.Text = Convert.ToString(v.Getnum_pasajero());
                    txtMatricula.Text = Convert.ToString(v.Getmatricula());
                    txtPlaca.Text = Convert.ToString(v.Getplaca());
                    if (v.Gettipo_vehiculo().Equals("AUTO"))
                    {
                        cmbTipoV.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbTipoV.SelectedIndex = 1;
                    }
                    string direccion = PuntoComa(Convert.ToString(v.Getplaca()));
                    if (!direccion.Equals(""))
                    {
                        btnImagenV.BackgroundImage = Image.FromFile(direccion);
                    }
                    else
                    {
                        btnImagenV.BackgroundImage = null;
                    }

                }
                
                cont++;
            }

           
        }
        public string PuntoComa(string placa)
        {
            
            string line;

            System.IO.StreamReader file =new System.IO.StreamReader(@"C:\\Users\\Chris_informatico\\Source\\Repos\\ProyectoPropietarios\\WindowsFormsApplication1\\WindowsFormsApplication1\\ModuloVehiculo-Grupo7\\Icons\\Img.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (placa.Equals(line.Split(';').First())) {
                    return line.Split(';').ElementAt(1);
                }
                
               
            }
            return "";
        }

        private void btnHM_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                HistoMan man = new HistoMan(txtID.Text);
                man.Show();
            }
            else
            {
                MessageBox.Show("Escoja un vehiculo");
            }
            
            
        }

        private void btnHI_Click(object sender, EventArgs e)
        {
                if (!txtID.Text.Equals(""))
                {
                    HistorialIn man = new HistorialIn(txtID.Text);
                    man.Show();
                }
                else
                {
                    MessageBox.Show("Escoja un vehiculo");
                }


            
        }
    }
}
