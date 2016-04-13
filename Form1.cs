using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Figura> Figuras;

        public Form1()
        {
            Figuras = new List<Figura>();
            InitializeComponent();
        }   

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                Figuras.Add(c);

 
            }
            else if(e.Button == MouseButtons.Right)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                Figuras.Add(r);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in Figuras) //polimorfismo
            {
                f.Dibuja(this);
            }
        }
    }
}
