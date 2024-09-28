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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uk, kk,alan,çevre;
            kk = Convert.ToInt32(textBox1.Text);
            uk = Convert.ToInt32(textBox2.Text);
            alan = uk * kk;
            çevre = 2 * (uk + kk);
            label5.Text = (alan.ToString());
            label6.Text = (çevre.ToString());


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new Form3();

            a.Show();
            this.Hide();
        }
    }
}
