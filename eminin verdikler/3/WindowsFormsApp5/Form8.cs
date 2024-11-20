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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        double cocuk,maas,zamlimaas,cocukmaas;
        
        private void Form8_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cocuk=Convert.ToDouble(comboBox1.SelectedIndex);
            maas = Convert.ToDouble(textBox1.Text);
            switch (cocuk)
            {
                case 0:
                    cocukmaas = (maas + (maas * 10) / 100);
                    zamlimaas = cocukmaas + maas;
                    textBox3.Text = zamlimaas.ToString();
                    textBox2.Text=cocukmaas.ToString();
                    break;
                case 1:
                    cocukmaas = (maas + (maas * 15) / 100);
                    zamlimaas = cocukmaas + maas;
                    textBox3.Text = zamlimaas.ToString();
                    textBox2.Text = cocukmaas.ToString();
                    break;
                case 2:
                    cocukmaas = (maas + (maas * 20) / 100);
                    zamlimaas = cocukmaas + maas;
                    textBox3.Text = zamlimaas.ToString();
                    textBox2.Text = cocukmaas.ToString();
                    break;
                case 3:
                    cocukmaas = (maas + (maas * 25) / 100);
                    zamlimaas = cocukmaas + maas;
                    textBox3.Text = zamlimaas.ToString();
                    textBox2.Text = cocukmaas.ToString();
                    break;



            }

        }
    }
}
