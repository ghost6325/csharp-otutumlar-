using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = "program devam deiyor...";
            checkBox1.Text = "lisans söz. kabul deiyorum";
            button2.Enabled = false;
            button1.Text = "GERİ";
            button2.Text = "İLERİ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "program devam deiyor...";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GERİ GİDİYOM");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("program ilerliyor");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
