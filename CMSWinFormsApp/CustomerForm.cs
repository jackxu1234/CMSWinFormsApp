using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox3, "");
            errCustForm.SetError(textBox4, "");
            errCustForm.SetError(textBox5, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = true;
            if (textBox1.Text == "")
            {
                errCustForm.SetError(textBox1, "Please specify a valid car number");
                flag = false; 
            }
            else 
            {
                errCustForm.SetError(textBox1, "");
            }
            if (textBox4.Text == "")
            {
                errCustForm.SetError(textBox4, "Please specify a valid name");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox4, "");

            }
            if (textBox5.Text == "")
            {
                errCustForm.SetError(textBox5, "Please specify a valid Makes");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox5, "");

            }
            if (textBox3.Text == "")
            {
                errCustForm.SetError(textBox3, "Please specify a valid Adress");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox3, "");

            }
            if (false == false)
                return;
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
