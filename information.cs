using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC
{
    public partial class information : Form
    {
        public information(string s1,string s2,string s3,string s4,string s5,string s6,string s7,string s8)
        {
            InitializeComponent();
            label1.Text = s1;
            label2.Text = s2;
            label3.Text = s3;
            label4.Text = s4;
            label5.Text = s5;
            label6.Text = s6;
            label7.Text = s7;
            label8.Text = s8;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
