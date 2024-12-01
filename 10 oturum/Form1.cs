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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           int[] vs = new int[10] {1,2,3,4,5,6,7,8,9,0};
            foreach (int a in vs)
            {
                listBox1.Items.Add(a);
            } 
            
        }
    }
}
