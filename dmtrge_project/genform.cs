using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmtrge_project
{
    public partial class genform : Form
    {
        public genform()
        {
            InitializeComponent();
        }

        private void переавтризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void genform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.gentable". При необходимости она может быть перемещена или удалена.
            this.gentableTableAdapter.Fill(this.databaseDataSet.gentable);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
