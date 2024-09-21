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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ("ad soyad");
            label2.Text = ("tc no");
            label3.Text = (" adres");
            textBox3.Multiline = true;
            textBox2.MaxLength = 11;
            this.Text = ("uygulama");
            this.BackColor = Color.Silver;
            this.Font = new Font("times new roman",12);
            textBox3.ScrollBars = ScrollBars.Vertical;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("isminiz:" + textBox1.Text + "\n" + "tc kimlik numaranız:" + "\n" + textBox2.Text + "\n" + "ev adresiniz:" + textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new Form5();
            a.Show();
            this.Hide();
        }
    }
}
