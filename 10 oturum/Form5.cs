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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int[] sayı = new int[50];
        private void Form5_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                sayı[i] = random.Next(-100, 100);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(sayı);//sıralar
            Array.Reverse(sayı);
            foreach (int a in sayı)
            {
                listBox1.Items.Add(a);
            }
            int min = Convert.ToInt32(listBox1.Items[0].ToString());
            int max = Convert.ToInt32(listBox1.Items[49].ToString());
            int fark = max - min;
            label1.Text = fark.ToString();

            /*for(int i = 0; i < sayı.Length - 1; i++)
            {
                for(int a=0;a<sayı.Length - i - 1; a++)
                {
                    if (sayı[a] > sayı[a + 1])
                    {
                        int s1 = sayı[a];
                        sayı[a] = sayı[a + 1];
                        sayı[a + 1] = s1;
                    }
                }
            }*/

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(int a in sayı)
            {
                if (a > 0)
                {
                    listBox2.Items.Add(a);
                }
                else
                {
                    listBox3.Items.Add(a);
                }
            }
        }

        
    }
}
