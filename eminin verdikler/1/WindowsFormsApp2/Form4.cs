using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string durum;
        double not1, not2, ortalama;

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            not1=Convert.ToDouble(textBox3.Text);
            not2=Convert.ToDouble(textBox4.Text);
            ortalama = (not1 + not2) / 2;
            listBox5.Items.Add(ortalama.ToString());
            if (ortalama >= 50)
                listBox6.Items.Add("Geçti");
            else
                listBox6.Items.Add("Kaldı");

            

        }
    }
}
