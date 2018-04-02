using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rbtRojo_CheckedChanged_1(object sender, EventArgs e)
        {
            lblRes.ForeColor = Color.Red;
        }

        private void rbtNegro_CheckedChanged_1(object sender, EventArgs e)
        {
            lblRes.ForeColor = Color.Black;
        }

        private void rbtVerde_CheckedChanged_1(object sender, EventArgs e)
        {
            lblRes.ForeColor = Color.Green;
        }

        private void rbt12_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Font = new Font(lblRes.Font.Name, 12);
        }

        private void rbt16_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Font = new Font(lblRes.Font.Name, 16);
        }

        private void rbt20_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Font = new Font(lblRes.Font.Name, 20);
        }

        private void rbtM1_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Text = rbtM1.Text;
        }

        private void rbtM2_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Text = rbtM2.Text;
        }
    }
}
