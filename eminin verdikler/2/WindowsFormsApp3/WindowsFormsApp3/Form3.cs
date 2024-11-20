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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double ad, fiyat, toplam,indirim;

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox3.Enabled= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form a = new AnaForm();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toplam = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           fiyat=Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked )
            {
                
                
                toplam = toplam + fiyat;
                indirim = (fiyat - (fiyat * 3) / 100);
                listBox1.Items.Add(textBox1.Text+" "+indirim.ToString());
                
            }
            else if (radioButton2.Checked)
            {
                toplam = toplam + fiyat;
                indirim = (fiyat - (fiyat * 5) / 100);
                listBox1.Items.Add(textBox1.Text +" "+ indirim.ToString());
            }
            else if(radioButton3.Checked)
            {
                toplam = toplam + fiyat;
                listBox1.Items.Add(textBox1.Text +" "+ fiyat.ToString());
            }
            
            textBox3.Text=toplam.ToString();


        }
    }
}
