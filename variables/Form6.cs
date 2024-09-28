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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int küp, kare,  s1;
            s1 = Convert.ToInt32(textBox1.Text);
            küp = s1 * s1 * s1;
            kare = s1 * s1;
            MessageBox.Show(küp.ToString()+kare.ToString());
           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int küp, kare, s1;
            s1 = Convert.ToInt32(textBox1.Text);
            küp = s1 * s1 * s1;
            kare = s1 * s1;
            MessageBox.Show(küp.ToString()+"   "+kare.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
