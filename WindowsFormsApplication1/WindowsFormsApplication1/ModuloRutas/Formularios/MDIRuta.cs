using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    public partial class MDIRuta : Form
    {
        private int childFormNumber = 0;
        public Form2 googlemaps { get; set; }

        public MDIRuta()
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

        private void historialKilometrajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmKilometraje km = new frmKilometraje ();
            km.MdiParent = this;
            km.Show();*/

        }

        private void calculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.MdiParent = this;
            //form.Show();
            if (this.googlemaps != null)
            {
                this.googlemaps.Focus();
            }
            else
            {
                this.googlemaps = new Form2();
                this.googlemaps.Closed += GoogleMapsOnClosed;
                this.googlemaps.Show();
            }
        }
        private void GoogleMapsOnClosed(object sender, EventArgs eventArgs)
        {
            this.googlemaps = null;
        }

        private void incidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* frmIncidencia formInci = new frmIncidencia();
            formInci.MdiParent = this;
            formInci.Show();*/
        }

        private void historialKiometrajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*datKilometraje datK = new datKilometraje();
            datK.MdiParent = this;
            datK.Show();*/
        }

        private void incidenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*datIncidencia datI = new datIncidencia();
            datI.MdiParent = this;
            datI.Show();*/
        }

        private void MDIRuta_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
