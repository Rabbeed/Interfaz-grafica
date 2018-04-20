using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }



        private void ventanaHija1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // crea una nueva ventana hija 
            frmHija ventanaHija = new frmHija("Ventana Hija 1",
            "\\imagenes\\1.jpg");
            ventanaHija.MdiParent = this; // set parent 
            ventanaHija.Show(); 
        }

        private void ventanaHija2ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                frmHija ventanaHija = new frmHija("Ventana Hija 2",
              "\\imagenes\\2.jpg"); ventanaHija.MdiParent = this; // set parent
                ventanaHija.Show();    
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void frmPadre_Load(object sender, EventArgs e)
        {
            menuStrip1.MdiWindowListItem = ventanaToolStripMenuItem;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
