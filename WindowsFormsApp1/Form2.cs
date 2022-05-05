using System;
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
    public partial class fomStudentLogin : Form
    {
        public fomStudentLogin()
        {
            InitializeComponent();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailId_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(textFullName.Text=="pooja" && textEmailId.Text=="poojacpatil99@gmail.com" && textContactNumber.Text=="9865789567" &&
                textAddress.Text=="Karad")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textFullName.Clear();
            textEmailId.Clear();
            textContactNumber.Clear();
            textAddress.Clear();
        }

        private void fomStudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
