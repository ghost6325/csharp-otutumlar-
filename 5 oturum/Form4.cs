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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fah, derece;
            if (textBox1.Text != "")
            {
                derece = Convert.ToDouble(textBox1.Text);
                fah = (derece * 1.8) + 32;
                textBox2.Text = fah.ToString();




            }
             else if (textBox2.Text != "")
            {
                fah = Convert.ToDouble(textBox2.Text);
                derece = (fah - 32) / 1.8;
                textBox1.Text = derece.ToString();

            }

        }
    }
}
