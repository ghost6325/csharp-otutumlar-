using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double fiyat,süre,toplam, minbus, taksi, ticari;

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new AnaForm();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            süre=Convert.ToDouble(textBox1.Text); 
            if (comboBox1.SelectedIndex == 0)
            {

                taksi = 5;
                taksi = (süre - 1) * 7.5;
                fiyat = taksi;
                toplam = toplam + fiyat;
                pictureBox1.ImageLocation = "taksi.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ticari = 15;
                ticari = (süre - 1) * 25;
                fiyat = ticari;
                toplam = toplam + fiyat;
                pictureBox1.ImageLocation = "ticari.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                minbus = 20;
                minbus = (süre - 1) * 30;
                fiyat = minbus;
                toplam = toplam + fiyat;
                pictureBox1.ImageLocation = "karsan.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            listBox1.Items.Add(fiyat.ToString());
            label3.Text= toplam.ToString();
        }
    }
}
