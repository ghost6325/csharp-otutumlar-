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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                listBox1.Visible = true;
                groupBox2.Visible = false;
                listBox2.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
               groupBox2.Visible = true;
               listBox2.Visible = true;
               groupBox1.Visible = false;
               listBox1.Visible = false;
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible=false;
            groupBox1.Visible=false;
            groupBox2.Visible=false;
            label2.Visible=false;
            label3.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                listBox2.Items.Add(checkBox4.Text);

            }
            if (checkBox5.Checked)
            {
                listBox2.Items.Add (checkBox5.Text);
            }
            if (checkBox6.Checked)
            {
                listBox2.Items.Add(checkBox6.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
