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
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }

        private void addaccountBtn_Click(object sender, EventArgs e)
        {
            string LababaX = loginBoxreg.Text.ToString();
            string paswdX = passwdBoxreg.Text.ToString();

        }
    }
}
