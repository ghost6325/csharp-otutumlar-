﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_oturum
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int[] sayı = new int[20];
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                sayı[i] = random.Next(1, 100);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int a in sayı)
            {
                if (a % 2 == 0)
                {
                    listBox1.Items.Add(a);
                }
                else
                {
                    listBox2.Items.Add(a);
                }
            }
        }
    }
}
