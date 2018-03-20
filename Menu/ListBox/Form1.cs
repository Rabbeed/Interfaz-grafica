using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agrega el elemento en el TextBox al Listbox
            lstDesplegar.Items.Add(txtEntrada.Text);
            txtEntrada.Clear(); txtEntrada.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // si existe un elemento seleccionado, obtiene su indice
            // lo pasa como parametro al metodo RemoveAt
            if (lstDesplegar.SelectedIndex != -1)
                lstDesplegar.Items.RemoveAt(lstDesplegar.SelectedIndex);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // borra todos los elementos del ListBox 
            lstDesplegar.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
