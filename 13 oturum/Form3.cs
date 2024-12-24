using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_oturum
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void ingyok()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp1 = textBox2.Text;
            string temp = textBox1.Text;
            string donanım = comboBox1.Text;
            int bos = donanım.IndexOf(" ");
            string don1 = donanım.Substring(0, bos);
            string ad = temp.Substring(0, 3);
            string kod = temp1.Substring(0, 4);

            string sonuc = String.Concat(ad, "-", kod,"-",don1).ToLower();
            sonuc = sonuc.Replace("ç", "c");
            sonuc = sonuc.Replace("ı", "i");
            sonuc = sonuc.Replace("ğ", "g");
            sonuc = sonuc.Replace("ğ", "g");
            sonuc = sonuc.Replace("ö", "o");
            sonuc = sonuc.Replace("ş", "s");
            label1.Text = sonuc.ToUpper();
            
        }
    }
}
