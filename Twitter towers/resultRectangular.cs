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
    public partial class resultRectangular : Form
    {
        public string resultstring;

        public resultRectangular()
        {
            InitializeComponent();
            


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            solutionlabel.Text = resultstring;
        }
    }
}
