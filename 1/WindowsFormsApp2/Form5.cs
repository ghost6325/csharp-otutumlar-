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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double fah, derece, toplam;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            { 
               derece=Convert.ToDouble(textBox1.Text);
                fah = (derece * 1.8) + 32;
                textBox2.Text = fah.ToString();


             

            }  
            if (textBox2.Text!="")
            {
                fah = Convert.ToDouble(textBox2.Text);
                derece = (fah - 32) / 1.8;
                textBox1.Text = derece.ToString();

            }
               
      


        }
    }
}
