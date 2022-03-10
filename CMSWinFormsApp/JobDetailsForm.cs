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
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                if (txtCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please Specify a valid Car Number");
                    txtCarNo.Focus();
                    return;

                }
                if (Convert.ToInt32(txtWorkerID.Text) < 1)
                {
                    MessageBox.Show("Please Specify a valid Worker  ID");
                    txtWorkerID.Focus();
                    return;

                }
                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today) {
                    MessageBox.Show("Please Specify a valid Date");
                    dateTimePicker1.Focus();
                    return;


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtCarNo_Leave(object sender, EventArgs e)
            {
                if ((txtCarNo.Text == "") || (txtCarNo.Text == null))
                { MessageBox.Show("Please Specify a valid Car Number");
                    txtCarNo.Focus();
                }
           
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
