using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Text = "1.";
            button2.Text = "2.";
            button3.Text = "3.";
            button6.Text = "4.";
            button5.Text = "5.";
            button4.Text = "6.";
            button9.Text = "7.";
            button8.Text = "8.";
            button7.Text = "9.";
            button10.Text = "0.";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            button1.Text = "1.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
