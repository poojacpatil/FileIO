using System;
using System. IO;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = Convert.ToInt32(txtEmpId.Text);
                string Name = txtName.Text;
                string Designation = txtDesignation.Text;
                int Salary = Convert.ToInt32(txtSalary.Text);
                string Department = txtDepartment.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(EmpId);
                bw.Write(Name);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Department);
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtDesignation.Text = br.ReadString();
                txtSalary.Text = br.ReadInt32().ToString();
                txtDepartment.Text = br.ReadString();
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
