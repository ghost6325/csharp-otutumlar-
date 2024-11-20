using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Enabled= false;
            pictureBox1.Visible= true;
            pictureBox3.Visible= true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="10/B")
                pictureBox3.Visible= false;
            else 
                pictureBox3.Visible= true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text=="Bilişim")
                pictureBox1.Visible = false;
            else
                pictureBox1.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new AnaForm();
            a.Show();
            this.Hide();

        }
    }
}
