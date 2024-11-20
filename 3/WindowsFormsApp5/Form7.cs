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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string renkler,yazirenk;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            yazirenk = Convert.ToString(comboBox2.Text);
            switch (yazirenk)
            {
                case "Sarı":
                    this.ForeColor = Color.Yellow;
                    break;
                case "Siyah":
                    this.ForeColor = Color.Black;
                    break;
                case "Mavi":
                    this.ForeColor = Color.Blue;
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            renkler=Convert.ToString(comboBox1.Text);

            switch (renkler)
            {
                case "Kırmızı":
                    this.BackColor = Color.Red;
                    
                    break;
                case "Sarı":
                    this.BackColor = Color.Yellow;
                    break;
                case "Siyah":
                    this.BackColor = Color.Black;
                    break;
                case "Mavi":
                    this.BackColor = Color.Blue;
                    break;
                case "Mor":
                    this.BackColor = Color.Purple;
                    break;
            }
        }
    }
}
