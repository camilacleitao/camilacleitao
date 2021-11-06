using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aula3_POC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textUser.Text == "Camila") && (textPwd.Text == "1234"))
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
