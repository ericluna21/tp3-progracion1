using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int primervalor = int.Parse(this.txt_primervalor.Text);
                int segundovalor = int.Parse(this.txt_SegundoValor.Text);
                int resultado = primervalor + segundovalor;
                MessageBox.Show("Resultado es " + resultado);
            }
            catch (Exception error)
            {
            
                MessageBox.Show("Ingrese un numero");
                MessageBox.Show(error.GetType().ToString());
            }

        }

        private void txt_primervalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SegundoValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
