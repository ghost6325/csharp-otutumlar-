using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double mesafe, zaman, mz, yaricap, cevre, alan, vize, final,ortalama;

        private void button3_Click(object sender, EventArgs e)
        {
            vize=Convert.ToDouble(textBox6.Text);
            final=Convert.ToDouble(textBox7.Text);
            vize = (vize * 40) / 100;
            final = (final * 60) / 100;
            ortalama= vize+final;
            MessageBox.Show("Ortalama: "+(ortalama.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yaricap=Convert.ToDouble(textBox3.Text);
            cevre=2*3.14*yaricap;
            alan = 3.14 * yaricap * yaricap;
            textBox4.Text = cevre.ToString();
            textBox5.Text = alan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            mesafe = Convert.ToDouble(textBox1.Text);
            zaman = Convert.ToDouble(textBox2.Text);
            mz = mesafe*zaman;
            label5.Text=mz.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox4.Enabled= false;
            textBox5.Enabled = false;
            label5.Visible=false;
        }
    }
}
