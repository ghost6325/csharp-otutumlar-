using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] sayı = new int[10];
        private void Form3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int ekle = random.Next(1, 100);
                sayı[i] = ekle;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(int a in sayı)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
