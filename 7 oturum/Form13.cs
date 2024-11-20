using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oturum_7
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        int s1, s2, s3, s4;

        private void button4_Click(object sender, EventArgs e)
        {
            s4 = 0;
            for (int i = 23; i <= 65; i++)
            {
                if (i % 5 == 0)
                {
                    s4 = s4 + i;
                }
            }
            MessageBox.Show(s4.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox4.Text);
            s2 = Convert.ToInt32(textBox5.Text);
            s3 = 0;
            for(int i = s1; i <= s2; i++)
            {
                s3 = s3 + i;
            }
            MessageBox.Show(s3.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox2.Text);
            s2 = Convert.ToInt32(textBox3.Text);
            s3 = 1;

            for (int i = 1; i <= s1; i++)
            {
                s3 = s3 * s2;
            }
            MessageBox.Show(s3.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s4 = Convert.ToInt32(textBox1.Text);
            s3 = 1;

            for (int i = s4; i >= 1; i--)
            {
                s3 = s3 * i;
            }
            MessageBox.Show(s3.ToString());
        }
    }
}
