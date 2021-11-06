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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camil\source\repos\POOII_Cristiane\Aula3_POC\DB_Hotel.mdf;Integrated Security=True";

            string Query = "INSERT INTO tbHospede(cpf, nome, data_checkin, data_checkout, num_quarto)" +
                           "VALUES('" + textCPF.Text + "','" + textNome.Text + "','" + textDtcheckin.Text + "','" + textDtcheckout.Text + "','" + textNumquarto.Text + "')";



            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Registro gravado com sucesso!");
        }
    }
}
