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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        FileStream fs;
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id=Convert.ToInt32(txtId.Text);
                string Name = txtName.Text;
                string Location=txtLocation.Text;
                 fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt",FileMode.Create, FileAccess.Write);
                BinaryWriter bw=new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(Name);
                bw.Write(Location);
                bw.Close();

                MessageBox.Show("Done");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                fs.Close();
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br=new BinaryReader(fs);   
                txtId.Text=br.ReadInt32().ToString(); 
                txtName.Text=br.ReadString();
                txtLocation.Text = br.ReadString();     
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id=Convert.ToInt32(txtId.Text);
                dept.Name=txtName.Text;
                dept.Location=txtLocation.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
               binary.Serialize(fs,dept);
                MessageBox.Show("Done");
            }
            catch(Exception ex)
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
                Department dept = new Department();
                
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept=(Department)binary.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml=new XmlSerializer(typeof(Department));    
                xml.Serialize(fs, dept);
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
                Department dept = new Department();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
        //Soap Serilization
        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\DeptSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
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
                Department dept = new Department();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\DeptSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                dept = (Department)soap.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
        //Json serialize
        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\Dept", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs,dept);
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
                Department dept = new Department();

                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\TestFolder1\Dept", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                 txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
