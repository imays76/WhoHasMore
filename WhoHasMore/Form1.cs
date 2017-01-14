using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoHasMore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1 = 0;
        int s2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            s1++;
            button1.Text = "배태환 : " + s1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s2++;
            button2.Text = "배지환 : " + s2;

        }
    }
}
