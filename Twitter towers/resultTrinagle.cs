using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter_towers
{
    public partial class resulttrinagle : Form
    {
        public string cir;
        public string drawing;
        public resulttrinagle()
        {
            InitializeComponent();
        }

        private void circumference_Click(object sender, EventArgs e)
        {
            solution.Text = cir;
        }

        private void print_Click(object sender, EventArgs e)
        {
            solution.Text = drawing;
        }
    }
}
