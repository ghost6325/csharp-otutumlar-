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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1,t1,t2;
            k1 = (Convert.ToInt32(textBox1.Text));
            t1 = k1 * 4;
            t2 = k1 * k1;
            textBox2.Text = (t1.ToString());
            textBox3.Text = (t2.ToString());
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new Form3();

            a.Show();
            this.Hide();
        }
    }
}
