using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        double sonuc,sayi,sayi1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(textBox1.Text);
            sayi1 = Convert.ToDouble(textBox2.Text);
            sonuc=Convert.ToDouble(comboBox1.SelectedIndex);
            
            switch (sonuc)
            {
                case 0:
                    sonuc = sayi + sayi1;
                    MessageBox.Show("Sayıların toplamı: " + sonuc);
                break;
                case 1:
                    sonuc = sayi - sayi1;
                    MessageBox.Show("Sayiların çıkarması: "+ sonuc);
                break;
                case 2:
                    sonuc = sayi * sayi1; 
                    MessageBox.Show("Sayıların çarpımı: " + sonuc);
                break;
                case 3:
                    sonuc = sayi % sayi1;
                    MessageBox.Show("Sayiların Modu: " + sonuc);
                break;

            }
        }
    }
}
