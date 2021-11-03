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


namespace Aula2_Login_Cadastro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\camil\source\repos\POOII_Cristiane\Aula2_Login_Cadastro\Cadastro.mdf; Integrated Security = True";

            string Query = "INSERT INTO Cliente(cpf, nome, endereco, telefone, email)" +
                           "VALUES('" + textCPF.Text + "','" + textNome.Text + "','" + textEndereco.Text + "','" + textTelefone.Text + "','" + textEmail.Text + "')";
            
            

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Registro gravado com sucesso!");
                  
        }
    }
}
