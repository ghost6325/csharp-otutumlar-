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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int harf= Convert.ToInt32(comboBox1.SelectedIndex);
            switch (harf)
            {
                case 0:
                    label2.Text = "A Harfi Alfabenin 1. Harfidir";
                break;
                case 1:
                    label2.Text = "B Harfi Alfabenin 2. Harfidir";
                break;
                case 2:
                    label2.Text = "C Harfi Alfabenin 3. Harfidir";
                break;
                case 4:
                    label2.Text = "D Harfi Alfabenin 5. Harfidir";
                break;
                case 5:
                    label2.Text = "E Harfi Alfabenin 6. Harfidir";
                break;









            }

        }
    }
}
