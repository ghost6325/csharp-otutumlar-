﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skuidgamed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("elendiniz");
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
            button3.Enabled = false;
            button4.Enabled = false;    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button8.Visible = true;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Visible = true;
            button12.Visible = true;
            button10.Enabled = false;
            button9.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elendiniz");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

        }


        private void button13_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
