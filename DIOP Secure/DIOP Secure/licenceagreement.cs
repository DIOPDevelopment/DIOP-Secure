using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DIOP_Secure
{
    public partial class licenceagreement : Form
    {
        public licenceagreement()
        {
            InitializeComponent();
           
        }

        

        private void licenceagreement_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You need to agree to the liscence agreement first");
            }
            else
            {
                this.Hide();
                RequirePass pass = new RequirePass();
                pass.Show();
            }
        }
    }
}
