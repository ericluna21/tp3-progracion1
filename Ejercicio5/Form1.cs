using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorminimo;
            int valormaximo = int.Parse(this.maximo.Text);
            int divisor;
            int primo;
            for (valorminimo = int.Parse(this.minimo.Text); valorminimo <= valormaximo; valorminimo++)
            {
                primo = 0;
                for (divisor = 2; divisor < valorminimo - 1 && primo == 0; divisor++)
                {
                    if (valorminimo % divisor == 0) primo = 1;
                }
                if (primo  == 0)
                {
                    this.ListaNumPrimos.Items.Add(valorminimo);
                }
            }
        }
    }
}
