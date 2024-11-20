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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi");
                break;
                case 2:
                    MessageBox.Show("Salı");
                break;
                case 3:
                    MessageBox.Show("Çarşamba");
                break;
                case 4:
                    MessageBox.Show("Perşembe");
                break;
                case 5:
                    MessageBox.Show("Cuma");
                break;
                case 6:
                    MessageBox.Show("Cumartesi");
                break;
                case 7:
                    MessageBox.Show("Pazar");
                break;
                default:
                    MessageBox.Show("Hata");
                break;



            }
        }
    }
}
