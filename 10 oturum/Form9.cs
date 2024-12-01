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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int[] yaz1 = new int[5];
        int[] yaz2 = new int[5];
        int[] perf = new int[5];
        int[] numara = new int[5];
        string[] ad = new string[5];
        int[] gec = new int[5];
        int[] kal = new int[5];
        string[] gk1 = new string[5];
        int i = 0;
        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                
                yaz1[i] = Convert.ToInt32(textBox3.Text);
                yaz2[i] = Convert.ToInt32(textBox4.Text);
                perf[i] = Convert.ToInt32(textBox5.Text);
                numara[i] = Convert.ToInt32(textBox1.Text);               
                ad[i] = textBox2.Text;

                int s1 = (yaz1[i] + yaz2[i] + perf[i])/3 ;
                if (s1 >= 50)
                {
                    //gec[i] = 1;
                    gk1[i] = "ÖĞRENCİ GEÇTİ";
                }
                else if (s1 < 50)
                {
                    //kal[i] = 2;
                    gk1[i] = "ÖRENCİ KALDI";
                }
                i++;
                
            }
            else
            {
                MessageBox.Show("sadece 5 öğrenci girilebilir");
                button1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Clear();
                for (int j = 0; j < i; j++)
                {
                    listBox1.Items.Add(
                    "İSİM:" + ad[j] +
                    "NUMARA:" + numara[j].ToString() +
                    "1.YAZILI:" + yaz1[j].ToString() +
                    "  2. YAZILI:" + yaz2[j].ToString() +
                    "PERFORMANS:" + perf[j].ToString() +
                    "GEÇME DURUMU" + gk1[j].ToString());
                }
            }
            else if (radioButton2.Checked == true)
            {
               for(int i = 0; i < gec.Length; i++)
                {
                    if (gk1[i] == "ÖĞRENCİ GEÇTİ")
                    {
                        listBox1.Items.Add(
                    "İSİM:" + ad[i] +
                    "NUMARA:" + numara[i].ToString() +
                    "1.YAZILI:" + yaz1[i].ToString() +
                    "  2. YAZILI:" + yaz2[i].ToString() +
                    "PERFORMANS:" + perf[i].ToString() +
                    "GEÇME DURUMU" + gk1[i].ToString());
                    }
                }
                
            }
            else if (radioButton3.Checked == true)
            {
                for (int i = 0; i < kal.Length; i++)
                {
                    if (gk1[i] == "ÖRENCİ KALDI")
                    {
                        listBox1.Items.Add(
                    "İSİM:" + ad[i] +
                    "NUMARA:" + numara[i].ToString() +
                    "1.YAZILI:" + yaz1[i].ToString() +
                    "  2. YAZILI:" + yaz2[i].ToString() +
                    "PERFORMANS:" + perf[i].ToString() +
                    "GEÇME DURUMU" + gk1[i].ToString());
                    }
                }
            }

            
        }
    }
}
