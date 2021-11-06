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
    public partial class Form6 : Form
    {
        private string str_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camil\source\repos\POOII_Cristiane\Aula3_POC\DB_Hotel.mdf;Integrated Security=True";
        SqlCommand objComand = null;
        SqlConnection objConect = null;

        public Form6()
        {
            InitializeComponent();
        }

        public void listarGrid()
        {
            string strSQL = "select * from tbHospede";

            objConect = new SqlConnection(str_Con);
            objComand = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objComand);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dataGridView1.DataSource = dtLista;
            }

            catch
            {
                MessageBox.Show("Erro!!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarGrid();
        }
    }
}
