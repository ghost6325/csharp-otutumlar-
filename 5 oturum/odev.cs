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
    public partial class odev : Form
    {
        public odev()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("mart");
                listBox1.Items.Add("nisan");
                listBox1.Items.Add("mayıs");
                this.BackColor = (Color.Green);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("haziran");
                listBox1.Items.Add("temmuz");
                listBox1.Items.Add("ağustos");
                this.BackColor = (Color.Yellow);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("eylül");
                listBox1.Items.Add("ekim");
                listBox1.Items.Add("kasım");
                this.BackColor = (Color.OrangeRed);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("aralık");
                listBox1.Items.Add("ocak");
                listBox1.Items.Add("şubat");
                this.BackColor = (Color.Blue);
            }

        }

        private void odev_Load(object sender, EventArgs e)
        {
            
        }
    }
}
