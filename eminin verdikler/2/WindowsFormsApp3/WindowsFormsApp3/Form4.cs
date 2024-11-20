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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double vki, boy, kilo;

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.MaxLength = 3;
            textBox2.MaxLength = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new AnaForm();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            boy = boy / 100;
            vki = kilo / (boy * boy);

            if (vki < 19)
            {
                textBox3.Text = ("zayıf");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "çikolata.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((vki > 19) && (vki < 25))
            {
                textBox3.Text = ("ideal");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "ideal.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((vki > 25) && (vki < 30))
            {
                textBox3.Text = ("hafif şişman");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "hafifşişman.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((vki > 30) && (vki < 45))
            {
                textBox3.Text = ("Şişman");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "şişman.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if ((vki > 46) && (vki < 50))
            {
                textBox3.Text = ("Sağlık Açısından Tehlikeli");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "penguen.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (vki>50)
            {
                textBox3.Text = ("Morbid");
                textBox4.Text = (vki.ToString());
                pictureBox1.ImageLocation = "morbid.jfif";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        }
    }


