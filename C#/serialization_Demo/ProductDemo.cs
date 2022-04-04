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
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace serialization_Demo
{
    public partial class ProductDemo : Form
    {
        public ProductDemo()
        {
            InitializeComponent();
        }
        private void binaryread_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream f = new FileStream(@"E:\Productbin.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                p =( Product)bf.Deserialize(f);
                txtId.Text = Convert.ToString(p.id);
                txtname.Text = p.name;
                txtlocatoion.Text = p.location;
                MessageBox.Show("SuccssefullyRead");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void binarywrite_Click(object sender, EventArgs e)
        {
            try
            {

                Product p = new Product();
                p.id = Convert.ToInt32(txtId.Text);
                p.name = txtname.Text;
                p.location = txtlocatoion.Text;
                FileStream f = new FileStream(@"E:\Productbin.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, p);
                f.Close();
                MessageBox.Show("Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream f = new FileStream(@"E:\jsonPro.json", FileMode.Open, FileAccess.Read);
                p = JsonSerializer.Deserialize<Product>(p);
                txtId.Text = p.id.ToString();
                txtname.Text = p.name;
                txtlocatoion.Text = p.location;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void jsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.id = Convert.ToInt32(txtId.Text);
                p.name = txtname.Text;
                p.location = txtlocatoion.Text;
                FileStream f = new FileStream(@"E:\jsonPro.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(f, p);
                f.Close();
                MessageBox.Show("Created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream f = new FileStream(@"E:\xmlPro.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer x = new XmlSerializer(typeof(Product));
                x.Deserialize(f);
                p.id = Convert.ToInt32(txtId.Text);
                p.name = txtname.Text;
                p.location = txtlocatoion.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.id = Convert.ToInt32(txtId.Text);
                p.name = txtname.Text;
                p.location = txtlocatoion.Text;
                FileStream f = new FileStream(@"E:\xmlPro.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer x = new XmlSerializer(typeof(Product));
                x.Serialize(f, p);
                f.Close();
                MessageBox.Show("created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sopread_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream f = new FileStream(@"E:\sopxml.xml", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                p = (Product)sf.Deserialize(f);
                txtId.Text = p.id.ToString();
                txtname.Text = p.name;
                txtlocatoion.Text = p.location;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sopwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.id = Convert.ToInt32(txtId.Text);
                p.name = txtname.Text;
                p.location = txtlocatoion.Text;
                FileStream f = new FileStream(@"E:\sopxml.xml", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(f, p);
                f.Close();
                MessageBox.Show("created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
