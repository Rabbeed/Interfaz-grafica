using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // crea un objeto grafico, una pluma y una brocha
            Graphics myGraphics = base.CreateGraphics();
            // crea una pluma usando el color DarkRed
            Pen myPen = new Pen(Color.DarkRed);
            // crea un relleno solido usando el color DarkRed
            SolidBrush mySolidBrush =
            new SolidBrush(Color.DarkRed);
            // borra el area de dibujo poniendo su color a White
            myGraphics.Clear(Color.White);
            // encuentra el indice find index, draw proper shape
            switch (imageComboBox.SelectedIndex)
            {
                case 0: // se selecciono Circulo
                    myGraphics.DrawEllipse(
                    myPen, 50, 50, 150, 150);
                    break;
                case 1: // se selecciono Rectangulo
                    myGraphics.DrawRectangle(
                    myPen, 50, 50, 150, 150);
                    break;
                   
                case 2: // se selecciono Elipse
                    myGraphics.DrawEllipse(
                    myPen, 50, 85, 150, 115);
                    break;
                case 3: // se selecciono pastel
                    myGraphics.DrawPie(
                    myPen, 50, 50, 150, 150, 0, 45);
                    break;
                case 4: // se selecciono Elipse Rellena
                    myGraphics.FillEllipse(
                    mySolidBrush, 50, 50, 150, 150);
                    break;
                case 5: // se selecciono rectangulo relleno
                    myGraphics.FillRectangle(
                    mySolidBrush, 50, 50, 150, 150);
                    break;
                case 6: // se selecciono elipse rellena
                    myGraphics.FillEllipse(
                    mySolidBrush, 50, 85, 150, 115);
                    break;
                case 7: // se selecciono pastel relleno
                    myGraphics.FillPie(
                    mySolidBrush, 50, 50, 150, 150, 0, 45);
                    break;
            }
        }
    }
}
