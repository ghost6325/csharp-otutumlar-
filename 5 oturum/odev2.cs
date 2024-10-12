using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oturum6
{
    public partial class odev2 : Form
    {
        public odev2()
        {
            InitializeComponent();
        }

        private void odev2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Bursa");
            comboBox1.Items.Add("Antalya");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kadıköy");
                comboBox2.Items.Add("Üsküdar");
                comboBox2.Items.Add("Bağcılar");
                comboBox2.Items.Add("Beşiktaş");
                comboBox2.Items.Add("fatih");              
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Çankaya");
                comboBox2.Items.Add("Keçiören");
                comboBox2.Items.Add("Mamak");
                comboBox2.Items.Add("Etimesgut");
                comboBox2.Items.Add("Yenimahalle");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Karşıyaka");
                comboBox2.Items.Add("Bornova");
                comboBox2.Items.Add("Konak");
                comboBox2.Items.Add("Buca");
                comboBox2.Items.Add("Bayraklı");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Osmangazi");
                comboBox2.Items.Add("Nilüfer");
                comboBox2.Items.Add("Yıldırım");
                comboBox2.Items.Add("İnegöl");
                comboBox2.Items.Add("Gemlik");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Muratpaşa");
                comboBox2.Items.Add("Konyaaltı");
                comboBox2.Items.Add("Kepez");
                comboBox2.Items.Add("Alanya");
                comboBox2.Items.Add("Manavgat");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
