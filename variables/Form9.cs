using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mes, zmn,orthız;
            mes = Convert.ToDouble(textBox1.Text);
            zmn = Convert.ToDouble(textBox2.Text);
            orthız = mes / zmn;
            label3.Text=(orthız.ToString());


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort, top;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            s3 = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + s3) / 3;
            top = (s1 + s2 + s3);
            label10.Text = top.ToString();
            label11.Text = ort.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double vize, final,ort;
            vize = Convert.ToDouble(textBox6.Text);
            final = Convert.ToDouble(textBox7.Text);
            final = vize * 40 / 100 + final * 60 / 100;
            MessageBox.Show(final.ToString());

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
