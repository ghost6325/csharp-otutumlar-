using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oturum_8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 50)
            {
                listBox1.Items.Add(i.ToString());
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 50)
            {
                listBox2.Items.Add(i.ToString());
                i = 2 + i;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    listBox3.Items.Add(i.ToString());

                }
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 20;
            while (i >= 0)
            {
                listBox4.Items.Add(i.ToString());
                i--;
            }
        }
    }
}
