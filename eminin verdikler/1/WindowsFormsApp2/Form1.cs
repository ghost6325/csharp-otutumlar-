using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible= true;
            double s1, sonuc;
            s1= Convert.ToDouble(textBox1.Text);
            sonuc = (s1 * 10) / 100;
            sonuc = s1 - sonuc;
            label3.Text=sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            double s2, sonuc;
            s2 = Convert.ToDouble(textBox1.Text);
            sonuc = (s2 * 25) / 100;
            sonuc = s2 - sonuc;
            label3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible  = true;
            double s3, sonuc;
            s3 = Convert.ToDouble(textBox1.Text);
            sonuc = (s3 * 50) / 100;
            sonuc = s3 - sonuc;
            label3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            double s4, sonuc;
            s4 = Convert.ToDouble(textBox1.Text);
            sonuc = (s4 * 75) / 100;
            sonuc = s4 - sonuc;
            label3.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible= false;
        }
    }
}
