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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "arkaplan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            button1.Text = "blue";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            button2.Text = "white";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            button3.Text = "yellow";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            button4.Text = "red";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = "renkler";
        }
    }
}
