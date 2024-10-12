using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_oturum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saat, fiyat;
            saat = Convert.ToDouble(textBox1.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                fiyat = 10 + 15 * (saat - 1);
                listBox1.Items.Add("taksi" + fiyat);
                pictureBox1.ImageLocation = "taksi.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if(comboBox1.SelectedIndex == 1)
            {
                fiyat = 20 + 30 * (saat - 1);
                listBox1.Items.Add("ticari" + fiyat);
                pictureBox1.ImageLocation = "ticariarac.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                fiyat = 35 + 45 * (saat - 1);
                listBox1.Items.Add("ticari" + fiyat);
                pictureBox1.ImageLocation = "ticariarac.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("taksi");
            comboBox1.Items.Add("ticari");
            comboBox1.Items.Add("minibus");
        }
    }
}
