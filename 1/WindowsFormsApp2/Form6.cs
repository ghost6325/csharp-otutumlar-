using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        double odeme,taksit;
        private void button1_Click(object sender, EventArgs e)
        {
            odeme = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked) 
                MessageBox.Show(odeme.ToString());

            else if (radioButton2.Checked)
            {
                odeme = odeme + (odeme * 4) / 100;
                taksit = (odeme)/2;
                
                MessageBox.Show("Birinci Fiyat: "+ taksit.ToString()+ "\n" + "İkinci Taksit: "+ taksit.ToString());
            }
            else if (radioButton3.Checked)
            {
                odeme = odeme + (odeme * 5) / 100;
                taksit= (odeme)/3;
                
                MessageBox.Show("Birinci Fiyat: " + taksit.ToString() + "\n" + "İkinci Taksit: " + taksit.ToString() + "\n" + "Üçüncü Taksit: " + taksit.ToString());


            }
            else if (radioButton4.Checked)
            {
                odeme = odeme + (odeme * 7) / 100;
                taksit=(odeme)/4;
                
                MessageBox.Show("Birinci Fiyat: " + taksit.ToString() + "\n" + "İkinci Taksit: " + taksit.ToString() + "\n" + "Üçüncü Taksit: " + taksit.ToString() + "\n" + "Dördüncü Taksit: " + taksit.ToString() );



            }
            else if (radioButton5.Checked)
            {
                odeme = odeme + (odeme * 9) / 100;
                taksit=(odeme)/5;
                
                MessageBox.Show("Birinci Fiyat: " + taksit.ToString() + "\n" + "İkinci Taksit: " + taksit.ToString() + "\n" + "Üçüncü Taksit: " + taksit.ToString() + "\n" + "Dördüncü Taksit: " + taksit.ToString() + "Beşinci Sayı: " + "\n" + taksit.ToString());

            }
        }
    }
}
