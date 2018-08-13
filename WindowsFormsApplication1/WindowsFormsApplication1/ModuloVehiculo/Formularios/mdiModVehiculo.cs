using System;
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
    public partial class mdiModVehiculo : Form
    {
        private int childFormNumber = 0;

        public mdiModVehiculo()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void AbrirFormularioHijo(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }


        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormularioHijo(new FormVehiculo());
            //panel1.SetAutoScrollMargin(frm_Vehiculo.Show());
            //frm_Vehiculo.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prueba
            AbrirFormularioHijo(new FormMantenimiento());
            //frm_Mantenimiento.MdiParent = this.MdiParent;
            //frm_Mantenimiento.Show();
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormDisponibilidad());
            //frm_Disponibilidad.MdiParent = this.MdiParent;
            //frm_Disponibilidad.Show();
        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormIncidencia());
            //frm_Incidencia.MdiParent = this.MdiParent;
            //frm_Incidencia.Show();
        }

        private void vehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new dataVehiculo());
            //frm_Vehiculo.MdiParent = this.MdiParent;
            //frm_Vehiculo.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new dataMantenimiento());
            //frm_Vehiculo.MdiParent = this.MdiParent;
            //frm_Vehiculo.Show();
        }

        private void disponibilidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new dataDisponibilidad());
            //frm_Vehiculo.MdiParent = this.MdiParent;
            //frm_Vehiculo.Show();
        }

        private void incidenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new dataIncidencias());
            //frm_Vehiculo.MdiParent = this.MdiParent;
            //frm_Vehiculo.Show();
        }

        private void MDImdiMod_Vehiculo_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void buscarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Buscar_Datos());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
