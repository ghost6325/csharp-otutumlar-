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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                isimler[i] = textBox1.Text;
                i++;
                label1.Text = i.ToString() + ". ismi girdiniz";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("en fazle 5 değer girilebilir");
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string a in isimler)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
