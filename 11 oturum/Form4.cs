using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_oturum
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] isim = new string[5];
        string[] ürün = new string[5];       
        double[] fiyat = new double[5];
        int i = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("üst");
            comboBox1.Items.Add("alt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                ürün[i] = comboBox1.Text;
                isim[i] = textBox1.Text;
                fiyat[i] = double.Parse(textBox2.Text);
                i++;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int a = 0; a < 5; a++)
            {
                if (ürün[a] == "üst")
                {
                    listBox1.Items.Add( isim[a]+" "+fiyat[a]);
                }
                else if(ürün[a] == "alt")
                {
                    listBox2.Items.Add(isim[a] + " " + fiyat[a]);
                }
            }
        }
    }
}
