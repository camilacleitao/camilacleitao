using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int operacao = 1;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            operacao = 3;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            double resultado;

            numero1 = Double.Parse(textBox1.Text);
            numero2 = Double.Parse(textBox2.Text);

            if (operacao == 1)
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 2)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 3)
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 4)
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString();
            }

        }

    }
}
