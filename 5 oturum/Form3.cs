using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oturum6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double s1, s2 ,ort;
            
            
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            ort = (s1 + s2) / 2;
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(s1.ToString());
            listBox4.Items.Add(s2.ToString());
            listBox5.Items.Add(ort.ToString());

            if (ort >= 50)
            {
                listBox6.Items.Add("geşti");
            }
            else
            {
                listBox6.Items.Add("kaldı");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}
