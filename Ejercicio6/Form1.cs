using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primernumero = 0;
            int segundonumero = 1;
            int siguientenumero;
            int numeroserie = int.Parse(this.numeros.Text);
            this.listBox1.Items.Add(primernumero + " " + segundonumero + "");
            siguientenumero = primernumero + segundonumero;

            for( int i=2; siguientenumero < numeroserie; i++)
            {
                this.listBox1.Items.Add(siguientenumero + " ");
                primernumero = segundonumero;
                segundonumero = siguientenumero;
                siguientenumero = primernumero + segundonumero;
            }
            
        }
    }
}
