using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void butclear_Click(object sender, EventArgs e)
        {

            txtuname.Clear();txtpass.Clear();
            MessageBox.Show("Cleared data");
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "Devashri" && txtpass.Text == "welcome")
            {
                MessageBox.Show("Welcome user " + txtuname.Text);

            }
            else
            {
                MessageBox.Show("Please Enter the Correct ID Pass");
            }
        }
    }
}
