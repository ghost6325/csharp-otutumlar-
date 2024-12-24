using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_oturum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hız()
        {
            int yol = Convert.ToInt32(textBox5.Text);
            int zaman = Convert.ToInt32(textBox7.Text);
            int snc = yol / zaman;
            MessageBox.Show(snc.ToString());

        }
        public int cev()
        {
            int cevre = Convert.ToInt32(textBox6.Text);
            int t1 = cevre * 4;
            return t1;
        }
        public void büyük(int s1, int s2)
        {
            if (s1 > s2)
            {
                MessageBox.Show(s1.ToString());
            }
            else if (s2 > s1)
            {
                MessageBox.Show(s2.ToString());
            }
        }
        public int alan(int u, int k)
        {
            int top = u * k;
            return top;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uz = Convert.ToInt32(textBox1.Text);
            int kı = Convert.ToInt32(textBox2.Text);
            int yaz = alan(uz, kı);
            MessageBox.Show(yaz.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox3.Text);
            int s2 = Convert.ToInt32(textBox4.Text);
            büyük(s1, s2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yaz2 = cev();
            MessageBox.Show(yaz2.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hız();
        }
    }
}
