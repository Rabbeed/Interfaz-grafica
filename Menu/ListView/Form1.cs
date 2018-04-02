using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {

        // registros iniciales
        string[,] contactos
       = { {"Juan Perez", "Av. Mexico 134", "juan@gmail.com" },
            {"Maria Lopez","5 de Mayo 25", "maria@hotmail.com"} };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // establece el mod de vista a Details
            lsvDatos.View = View.Details;
            // agrega tres columnas con diferentes anchos y alineaciones
            lsvDatos.Columns.Add("Nombre", 220, HorizontalAlignment.Left);
            lsvDatos.Columns.Add("Email", 200, HorizontalAlignment.Center);
            lsvDatos.Columns.Add("Telefono", 120, HorizontalAlignment.Right);
            // crea un elemento de tipo ListViewItem
            ListViewItem registro;
            // agrega los registros iniciales en el arreglo contactos
            for (int i = 0; i < contactos.GetLength(0); i++)
            {
                registro = new ListViewItem(); // crea un elemento vacio
                registro.Text = contactos[i, 0]; // le agrega el nombre
                                                 // agrega el resto de los campos
                for (int j = 1; j < contactos.GetLength(1); j++)
                {
                    registro.SubItems.Add(contactos[i, j]);
                }
                // lo agrega al ListView
                lsvDatos.Items.Add(registro);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // crea un elemento de tipo ListViewItem
            ListViewItem registro = new ListViewItem();
            // rellena el elemento con los datos
            registro.Text = txtNombre.Text;
            registro.SubItems.Add(txtEmail.Text);
            registro.SubItems.Add(txtTelefono.Text);
            // lo agrega al ListView de contactos
            lsvDatos.Items.Add(registro);
        }
    }
}
