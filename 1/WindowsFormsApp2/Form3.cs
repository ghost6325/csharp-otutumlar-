using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double ev,giyecek,yiyecek,okul,toplam,ev1,giyecek1,yiyecek1,okul1,toplam1;

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label13.Visible = true;
            label6.ForeColor = Color.Red;
            label13.ForeColor=Color.Red;
            ev = Convert.ToDouble(textBox1.Text);
            giyecek= Convert.ToDouble(textBox2.Text);
            yiyecek= Convert.ToDouble(textBox3.Text);
            okul= Convert.ToDouble(textBox4.Text);
            toplam= ev + giyecek+ yiyecek + okul;
            label6.Text=toplam.ToString();
            ev1 = (ev1%60)/100;
            giyecek1=giyecek+(giyecek*30)/100;
            yiyecek1=yiyecek+(yiyecek*50)/100;
            okul1=okul+(okul*40)/100;
            toplam1 = ev1 + giyecek1 + yiyecek1 + okul1;
            label13.Text=toplam1.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label13.Visible = false;
        }
    }
}
