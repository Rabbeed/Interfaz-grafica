using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void mnuAcercade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un ejemplo \n" + "del uso de menus.", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Limpia todas las marcas de chequeo de las opciones de color 
        private void LimpiarColor() {
            mnuNegro.Checked = false;
            mnuAzul.Checked = false;
            mnuRojo.Checked = false;
            mnuVerde.Checked = false;
        }

        // Limpia todas las marcas de chequeo de las opciones de fuente 
        private void LimpiaFuente(){
            mnuTimes.Checked = false;
            mnuCourier.Checked = false;
            mnuComic.Checked = false;
        }

        private void mnuNegro_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            lblRes.ForeColor = Color.Black;
            mnuNegro.Checked = true;
        }

        private void mnuAzul_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            lblRes.ForeColor = Color.Blue;
            mnuAzul.Checked = true;
        }

        private void mnuRojo_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            lblRes.ForeColor = Color.Red;
            mnuRojo.Checked = true;
        }

        private void mnuVerde_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            lblRes.ForeColor = Color.Green;
            mnuVerde.Checked = true;
        }

        private void mnuCourier_Click(object sender, EventArgs e)
        {
            LimpiaFuente();
            lblRes.Font = new Font("Courier New", 12,
            lblRes.Font.Style);
            mnuCourier.Checked = true;
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNegrita.Checked = !mnuNegrita.Checked;
            // Usa Xor para cambiar a negrita, deja igual los otros estilos
            lblRes.Font = new Font(lblRes.Font.FontFamily, 12,
            lblRes.Font.Style ^ FontStyle.Bold);
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuCursiva.Checked = !mnuCursiva.Checked;
            lblRes.Font = new Font(lblRes.Font.FontFamily, 12,
            lblRes.Font.Style ^ FontStyle.Italic);
        }

        private void mnuComic_Click(object sender, EventArgs e)
        {
            LimpiaFuente();
            lblRes.Font = new Font("Comic Sans MS", 12, lblRes.Font.Style);
            mnuTimes.Checked = true;
        }

        private void mnuTimes_Click(object sender, EventArgs e)
        {
            LimpiaFuente();
            lblRes.Font = new Font("Times New Roman", 12,
            lblRes.Font.Style);
            mnuTimes.Checked = true;
        }
    }
}
