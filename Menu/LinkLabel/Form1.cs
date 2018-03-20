using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblDrive.LinkVisited = true;
            System.Diagnostics.Process.Start(@"c:\");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSitioWeb.LinkVisited = true;
            System.Diagnostics.Process.Start("Iexplore", "www.uaz.edu.mx");
        }

        private void lblBlocNotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBlocNotas.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
