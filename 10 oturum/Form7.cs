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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int[] sayı = new int[s1];
            int bas = Convert.ToInt32(textBox2.Text);
            int son = Convert.ToInt32(textBox3.Text);
            int toplam = 0;

            Random random = new Random();
            for (int i = 0; i < s1 ; i++)
            {
                sayı[i] = random.Next(bas, son);
            }

            foreach(int a in sayı)
            {
                listBox1.Items.Add(a);
                toplam = toplam + a;
            }
            label1.Text = toplam.ToString();
        }
    }
}
