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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+" "+textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox3.Text))
            {
                listBox1.SelectedItem = textBox3.Text;
                MessageBox.Show("Aradığınız Değer Bulundu");
            }
            else
                MessageBox.Show("Aradığınız Eleman Bulunamadı");
        }
    }
}
