using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;

namespace serialization_Demo
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void jsonRead_Click(object sender, EventArgs e)
        {

        }

        private void jsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txtid.Text);
                p.Name = txtname.Text;
                p.Price = Convert.ToDouble(txtpric.Text);
                p.Quantity = Convert.ToInt32(txtquan.Text);
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\ProductJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(f, p);
                f.Close();
                MessageBox.Show("File created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
