using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_oturum
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i1 = 1;
            do
            {
                listBox1.Items.Add(i1);
                i1 = i1 + 2;
            } while (i1 < 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i2 = 5;
            do
            {
                if (i2 % 3 == 0)
                {
                    listBox1.Items.Add(i2);
                }
                
                i2++;
            } while (i2 <= 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i3 = 7;
            do
            {
                if ((i3 % 3 == 0) && (i3%5==0))
                {
                    listBox1.Items.Add(i3);
                }

                i3++;
            } while (i3 <= 80);
        }
    }
}
