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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.MdiParent = this;
            obj.Show();
        }

        private void hóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.MdiParent = this;
            obj.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.MdiParent = this;
            obj.Show();
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
