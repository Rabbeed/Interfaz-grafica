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

namespace MDI
{
    public partial class frmHija : Form
    {
        public frmHija(string titulo, string nombreArchivo)
        {
            InitializeComponent();
            Text = titulo;
            pictureBox1.Image = Image.FromFile(
            Directory.GetCurrentDirectory() + nombreArchivo);
        }

        private void frmHija_Load(object sender, EventArgs e)
        {

        }

    }
}
