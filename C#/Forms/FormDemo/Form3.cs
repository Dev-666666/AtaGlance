using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FormDemo
{
    public partial class FormDept : Form
    {
        public FormDept()
        {
            InitializeComponent();
        }

        private void butfile_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Already Exist");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created");
            }
        }

        private void butfolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo\good.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("Already Exist");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("Created");
            }
        }

        private void butread_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("");
        }
    }
}
