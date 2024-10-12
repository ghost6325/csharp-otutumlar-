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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ev, giy, yiy, oku, ilk_top, son_top;
            ev = Convert.ToDouble(textBox1.Text);
            giy = Convert.ToDouble(textBox2.Text);
            yiy = Convert.ToDouble(textBox3.Text);
            oku = Convert.ToDouble(textBox4.Text);
            ilk_top = oku + yiy + ev + giy;
            ev = ev * 1.60;
            giy = giy * 1.30;
            yiy = yiy + 1.50;
            oku = oku * 1.40;
            son_top = oku + yiy + ev + giy;
            label5.Text = ilk_top.ToString();
            label6.Text = son_top.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
