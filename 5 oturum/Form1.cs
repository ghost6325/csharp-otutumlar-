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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fıyat, indirim_oranı, indirimlifiyat, sonfiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            
            fıyat = Convert.ToDouble(textBox1.Text);
            indirim_oranı = 0.10;
            indirimlifiyat = fıyat * indirim_oranı;
            sonfiyat = fıyat - indirimlifiyat;
            label1.Text = (sonfiyat.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fıyat = Convert.ToDouble(textBox1.Text);
            indirim_oranı = 0.25;
            indirimlifiyat = fıyat * indirim_oranı;
            sonfiyat = fıyat - indirimlifiyat;
            label1.Text = (sonfiyat.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            fıyat = Convert.ToDouble(textBox1.Text);
            indirim_oranı = 0.50;
            indirimlifiyat = fıyat * indirim_oranı;
            sonfiyat = fıyat - indirimlifiyat;
            label1.Text = (sonfiyat.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            fıyat = Convert.ToDouble(textBox1.Text);
            indirim_oranı = 0.75;
            indirimlifiyat = fıyat * indirim_oranı;
            sonfiyat = fıyat - indirimlifiyat;
            label1.Text = (sonfiyat.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
