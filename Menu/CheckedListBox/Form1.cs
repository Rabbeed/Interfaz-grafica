using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clbLenguajes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string elemento = clbLenguajes.SelectedItem.ToString();
            // si el elemento es checado, lo agrega al ListBox
            // si es deschecado lo elimina del ListBox
            if (e.NewValue == CheckState.Checked)
                lstDesplegar.Items.Add(elemento);
            else
                lstDesplegar.Items.Remove(elemento);
        }
    }
}
