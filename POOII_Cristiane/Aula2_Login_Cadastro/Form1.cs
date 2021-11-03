using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_Login_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Camila") && (textBox2.Text == "1234"))
            {
                Form2 obj = new Form2();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login e/ou Senha inválidos");
            }

        }
    }
}
