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
    }
}
