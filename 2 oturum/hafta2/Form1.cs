﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "merhaba dünya";
            this.BackColor = Color.White;
            this.Font = new Font("Tahoma",12);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("merhaba dünya");
            button2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "GİRİŞ";
            textBox1.Text = "merhaba";
        }
    }
}
