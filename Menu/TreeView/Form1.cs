using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode nodo, nodo2; // objetos de tipo nodo de arbol
            string[] carnesfrias = { "Jamon", "Tocino", "Salchicha" };
            // agrega el nodo raiz y guarda su referencia en nodo
            nodo = treDirectorio.Nodes.Add("SuperMercado");
            // agrega un nodo hijo y guarda su referencia en nodo2
            // luego agrega dos nodos hijos
            nodo2 = nodo.Nodes.Add("Frutas");
            nodo2.Nodes.Add("Manzana");
            nodo2.Nodes.Add("Pera");

            nodo2 = nodo.Nodes.Add("Verduras");
            nodo2.Nodes.Add("Lechuga");
            nodo2.Nodes.Add("Tomate");
            // agrega los elementos del arreglo carnesfrias
            // como hijos de nodo2
            nodo2 = nodo.Nodes.Add("Carnes Frias");
            foreach (string articulo in carnesfrias)
                nodo2.Nodes.Add(articulo);
            nodo.Expand(); // muestra los nodos hijos de nodo

        }

   

        private void treDirectorio_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode nodo;
            lstNodos.Items.Clear();

            nodo = treDirectorio.SelectedNode; // guarda el nodo seleccionado
                                               // obtiene el numero de nodos hijo del nodo actual y lo muestra
            lblNodos.Text = nodo.GetNodeCount(false).ToString();
            // agrega los nodos hijo del nodo seleccionado al ListBox
            foreach (TreeNode n in nodo.Nodes)
                lstNodos.Items.Add(n.Text);
        }
    }
}
