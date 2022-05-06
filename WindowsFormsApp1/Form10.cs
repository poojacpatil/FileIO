using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int BatchId = Convert.ToInt32(txtBatchId.Text);
                string BatchName = txtBatchName.Text;
                 string StartDate = txtStartDate.Text;
                 string EndDate = txtEndDate.Text;
                string Location = txtLocation.Text;
                string TrainerName = txtTrainerName.Text;
                fs = new FileStream(@"c:\Users\Pankaj\source\repos\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(BatchId);
                bw.Write(BatchName);
                bw.Write(StartDate);
                bw.Write(EndDate);
                bw.Write(Location);
                bw.Write(TrainerName);
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
                txtBatchId.Text = br.ReadInt32().ToString();
                txtBatchName.Text = br.ReadString();
                txtStartDate.Text = br.ReadString();
                txtEndDate.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                txtTrainerName.Text = br.ReadString();
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
