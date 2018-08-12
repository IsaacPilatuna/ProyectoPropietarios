using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
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

        private void regsitroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo frm_Vehiculo = new FormVehiculo();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimiento frm_Vehiculo = new FormMantenimiento();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisponibilidad frm_Vehiculo = new FormDisponibilidad();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIncidencia frm_Vehiculo = new FormIncidencia();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void vehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataVehiculo frm_Vehiculo = new dataVehiculo();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           dataMantenimiento frm_Vehiculo = new dataMantenimiento();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void disponibilidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataDisponibilidad frm_Vehiculo = new dataDisponibilidad();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void incidenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataIncidencias frm_Vehiculo = new dataIncidencias();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }

        private void mdiModVehiculo_Load(object sender, EventArgs e)
        {

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pruebaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Prueba frm_Vehiculo = new Prueba();
            frm_Vehiculo.MdiParent = this;
            frm_Vehiculo.Show();
        }
    }
}
