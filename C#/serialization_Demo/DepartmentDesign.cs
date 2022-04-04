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
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;


namespace serialization_Demo
{
    public partial class DepartmentDesign : Form
    {
        public DepartmentDesign()
        {
            InitializeComponent();
        }

       
        private void butbwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = txtlocation.Text;
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\Fbinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dept);
                f.Close();
                MessageBox.Show("Created");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void butjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = txtlocation.Text;
                //2. Create a file & open in write mode 
                FileStream f = new FileStream(@"E:\Newjson.json", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                JsonSerializer.Serialize(f, dept);
                f.Close();
                MessageBox.Show("File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\Fjson.json", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(f);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = txtlocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\Fsoap.soap", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\Fsoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sp = new SoapFormatter();
                dept = (Department)sp.Deserialize(f);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = txtlocation.Text;
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCompany\FileClassStore\Fxml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer x = new XmlSerializer(typeof(Department));
                x.Serialize(f, dept); f.Close();
                MessageBox.Show("File created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butbread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream f = new FileStream(@"E:\TrainingXtenITCompCnyompa\FileClassStore\Fbinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(f);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
