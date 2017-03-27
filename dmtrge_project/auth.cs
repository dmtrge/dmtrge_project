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
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string authX = logintbox.Text();
            string passwdX = passwdbox.Text();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            regform = new regform();
            
        }
    }
}
