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
    public partial class ödev : Form
    {
        public ödev()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ty, net, dogru, yanlıs;
            dogru = Convert.ToInt32(textBox1.Text);
            yanlıs = Convert.ToInt32(textBox2.Text);
            ty = yanlıs / 4;
            net = dogru - ty;
            textBox3.Text = net.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            double ty ,net, dogru, yanlıs;
            dogru = Convert.ToInt32(textBox4.Text);
            yanlıs = Convert.ToInt32(textBox5.Text);
            ty = yanlıs / 4;
            net = dogru - ty;
            textBox6.Text = net.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ty, net, dogru, yanlıs;
            dogru = Convert.ToInt32(textBox7.Text);
            yanlıs = Convert.ToInt32(textBox8.Text);
            ty = yanlıs / 4;
            net = dogru - ty;
            textBox9.Text = net.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
        }
    }
}
