using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DIOP_Secure
{
    public partial class RequirePass : Form
    {
        public RequirePass()
        {
            InitializeComponent();
        }

        

        

        private void checkpass(string[] passes)
        {
            string password = textBox1.Text;
            int wrongpasses = 0;
            for (int i = 0;  i < passes.Length; i++)
                {
                if (password == passes[i])
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                    break;

                }
                else
                {
                    wrongpasses++;
                    continue;
                }
                

            }
            if (wrongpasses == 3)
            {
                MessageBox.Show("Incorrect Password");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string[] usablepasswords = { "asd", "test123", "testtest" };
            checkpass(usablepasswords);
        }
    }
}
