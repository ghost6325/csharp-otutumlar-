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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string metin;
            metin = "bu bir metin";
            MessageBox.Show(metin);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = ("metin");
            radioButton2.Text = ("karaqkter");
            radioButton3.Text = ("byte");
            radioButton4.Text = ("int");
            radioButton5.Text = ("ondalıklı sayı");
            radioButton6.Text = ("mantıksal");
            radioButton1.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            char karakter;
            karakter = '?';
            MessageBox.Show(karakter.ToString());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            byte bitler;
            bitler = 122;
            MessageBox.Show(bitler.ToString());
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int sayı;
            sayı = 12345;
            MessageBox.Show(sayı.ToString());
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            double onda;
            onda = 12.34;
            MessageBox.Show(onda.ToString());
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            bool mantık;
            mantık = true;
            MessageBox.Show(mantık.ToString());
        }
    }
}
