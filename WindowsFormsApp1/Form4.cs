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
    }
}
