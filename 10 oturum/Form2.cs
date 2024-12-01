using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_oturum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] vs = new int[10];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                vs[i] = Convert.ToInt32(textBox1.Text);
                i++;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int a in vs)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
