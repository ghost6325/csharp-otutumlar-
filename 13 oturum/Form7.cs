using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_oturum
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form a = new Form8();
            a.ShowDialog();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form a = new Form9();
            a.ShowDialog();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form a = new Form10();
            a.ShowDialog();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form a = new Form11();
            a.ShowDialog();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form a = new Form12();
            a.ShowDialog();
            this.Hide();

        }
    }
}
