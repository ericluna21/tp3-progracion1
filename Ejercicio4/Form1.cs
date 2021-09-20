using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(this.valor1.Text);
            int valor2 = int.Parse(this.valor2.Text);
            int resultado = valor1 - valor2;
            string resta = resultado.ToString();
            this.Resultado.Text = resta;
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(this.valor1.Text);
            int valor2 = int.Parse(this.valor2.Text);
            int resultado = valor1 + valor2;
            string suma = resultado.ToString();
            this.Resultado.Text = suma;
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(this.valor1.Text);
            int valor2 = int.Parse(this.valor2.Text);
            int resultado = valor1 * valor2;
            string multiplicar = resultado.ToString();
            this.Resultado.Text = multiplicar;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(this.valor1.Text);
            int valor2 = int.Parse(this.valor2.Text);
            int resultado = valor1 / valor2;
            string division = resultado.ToString();
            this.Resultado.Text = division;
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            double valor1 = int.Parse(this.valor1.Text);
            double valor2 = int.Parse(this.valor2.Text);
            double resultado = Math.Pow(valor1,valor2);
            string potencia = resultado.ToString();
            this.Resultado.Text = potencia;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            double valor1 = int.Parse(this.valor1.Text);
            double valor2 = int.Parse(this.valor2.Text);
            double resultado1 = Math.Sqrt(valor1);
            double resultado2 = Math.Sqrt(valor2);
            string raizcuadrada1 = resultado1.ToString();
            string raizcuadrada2 = resultado2.ToString();
            this.Resultado.Text = raizcuadrada1+"; "+raizcuadrada2;
        }
    }
}
