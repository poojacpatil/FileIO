using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                string Name = txtName.Text;
                int Price = Convert.ToInt32(txtPrice.Text);
                string CategoryName = txtCategoryName.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(Name);
                bw.Write(Price);
                bw.Write(CategoryName);
                bw.Close();

                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                fs.Close();
            }
        }

        private void btbBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPrice.Text = br.ReadInt32().ToString();
                txtCategoryName.Text = br.ReadString();
                br.Close(); //close the opeation reader
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();  //free the resource
            }
        }

        //XML serialization
        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(txtId.Text);
                product.Name = txtName.Text;
                product.Price = Convert.ToInt32(txtPrice.Text);
                product.CategoryName = txtCategoryName.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\productXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, product);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\productXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                product = (Product)xml.Deserialize(fs);
                txtId.Text = product.Id.ToString();
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
                txtCategoryName.Text = product.CategoryName;
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        //Soap Serialization
        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(txtId.Text);
                product.Name = txtName.Text;
                product.Price = Convert.ToInt32(txtPrice.Text);
                product.CategoryName = txtCategoryName.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\productSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, product);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\productSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                product = (Product)soap.Deserialize(fs);
                txtId.Text = product.Id.ToString();
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
                txtCategoryName.Text = product.CategoryName;
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(txtId.Text);
                product.Name = txtName.Text;
                product.Price = Convert.ToInt32(txtPrice.Text);
                product.CategoryName = txtCategoryName.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\product", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, product);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\product", FileMode.Open, FileAccess.Read);
                product = JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = product.Id.ToString();
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();   
                txtCategoryName.Text = product.CategoryName;
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
    
}        
    
    



