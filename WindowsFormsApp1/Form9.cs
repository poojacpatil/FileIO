using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        FileStream fs;
        //Binary serialization
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text);
                string Name = txtName.Text;
                string AutherName = txtAutherName.Text;
                int Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(AutherName);
                bw.Write(Price);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtAutherName.Text= br.ReadString();
                txtPrice.Text = br.ReadInt32().ToString();
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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                   Book book= new Book ();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName= txtAutherName.Text;    
                book.Price = Convert.ToInt32(txtPrice.Text);
               fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\bookXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
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
                Book book = new Book();
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\BookXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAutherName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
              
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
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAutherName.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\bookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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
                   Book book = new Book();
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\bookSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAutherName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
               
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

        //Json Serialization
        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAutherName.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
               fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\book", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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
                 Book book = new Book();
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\book", FileMode.Open, FileAccess.Read);
                 book = JsonSerializer.Deserialize<Book>(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAutherName.Text=book.AuthorName; 
                txtPrice.Text = book.Price.ToString();
                
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
