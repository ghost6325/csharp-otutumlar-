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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double üm, üf, h;
            üm = Convert.ToDouble(comboBox1.SelectedItem);
            üf = Convert.ToDouble(textBox1.Text);
            h = üm * üf;
            h = (üf * üm) - (üf * üm * 10 / 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int üm, üf, h;
            üm = Convert.ToInt32(comboBox1.SelectedItem);
            üf = Convert.ToInt32(textBox1.Text);
            h = üm * üf;
            textBox2.Text = h.ToString();

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double üm, üf, h;
            üm = Convert.ToDouble(comboBox1.SelectedItem);
            üf = Convert.ToDouble(textBox1.Text);
            h = üm * üf;
            h = (üf * üm) - (üf * üm * 20 / 100);
        }
    }
}
