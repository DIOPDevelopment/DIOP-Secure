﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DIOP_Secure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\reald\\source\\repos\\DIOP Secure\\DIOP Secure\\passwords.txt";
            File.Create(path);
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            newadded();
            string startupPath = Environment.CurrentDirectory;
            //MessageBox.Show(startupPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void newadded()
        {
            setPasswords();
            setUsernames();
           // MessageBox.Show("suscessfully added");
            label2.Text = "";
            label3.Text = "";
            getPasswords();
            getUsernames();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            getPasswords();
            getUsernames();
        }
        
        
        private void getPasswords()
        {
            string path = @"passwords.txt";
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                label2.Text += line;
                label2.Text += "\r\n";
            }
            reader.Close();
        }

        private void setPasswords()
        {
            string path = @"passwords.txt";
            //File.WriteAllText(path, textBox1.Text);
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter wr = new StreamWriter(fs);
            wr.WriteLine(textBox1.Text);
            wr.Close();
            fs.Close();
           //MessageBox.Show("suscessfully added the text");
        }

        private void setUsernames()
        {
            string path = @"username.txt";
            //File.WriteAllText(path, textBox1.Text);
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter wr = new StreamWriter(fs);
            wr.WriteLine(textBox4.Text);
            wr.Close();
            fs.Close();
            
        }

        private void getUsernames()
        {
            string path = @"username.txt";
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                label3.Text += line;
                label3.Text += "\r\n";
            }
            reader.Close();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequirePass pass = new RequirePass();
            pass.Show();
        }*/

        private void encryption()
        {

        }
    }
}
