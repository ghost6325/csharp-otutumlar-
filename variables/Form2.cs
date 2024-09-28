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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2,toplam ;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            toplam = s1 + s2;
            MessageBox.Show(toplam.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, bolme;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            bolme = s1 / s2;
            MessageBox.Show(bolme.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, cıkarma;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            cıkarma = s1 - s2;
            MessageBox.Show(cıkarma.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form a = new Form3();

            a.Show();
            this.Hide();
        }
    }
}
