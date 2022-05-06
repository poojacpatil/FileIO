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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

    

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deletToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

      

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult result = fontDialog.ShowDialog();  
            if(result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialog=new ColorDialog();
            DialogResult result=ColorDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                richTextBox1.SelectionColor = ColorDialog.Color;
            }
        }

   

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd= new SaveFileDialog();
                sd.DefaultExt = ".txt";
                //meaning of * is any file name with following extension
                sd.Filter = "Text Dococument(*.txt)|*.txt| Word(*.docx)|*.docx";
                DialogResult result=sd.ShowDialog();
                if(result== DialogResult.OK )
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od=new OpenFileDialog();
                od.Filter = "Text Dococument(*.txt)|*.txt| Word(*.docx)|*.docx";
                DialogResult result = od.ShowDialog();  
                if( result==DialogResult.OK )
                {
                    StreamReader sr =new StreamReader(od.FileName);
                    richTextBox1.Text= sr.ReadToEnd();  
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
