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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboStatus.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camil\source\repos\POOII_Cristiane\Aula3_POC\DB_Hotel.mdf;Integrated Security=True";

            string Query = "INSERT INTO tbFuncionario(cpf, nome, data_nasc, data_contrat, status)" +
                           "VALUES('" + textCPF.Text + "','" + textNome.Text + "','" + textDtnasc.Text + "','" + textDtcontrat.Text + "','" + comboStatus.Text + "')";



            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Registro gravado com sucesso!");
        }
               
    }
}
