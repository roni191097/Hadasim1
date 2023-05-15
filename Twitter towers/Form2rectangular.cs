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
    public partial class Form2rectangular : Form
    {
        public double hight = 0;
        public double width = 0;
        public double area =0;
        public double circumference = 0;
        public double difference = 0;
        public double solution;



        public Form2rectangular()
        {

            InitializeComponent();
        }

        private void textBoxHight_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string Hight = textBoxHight.Text;
             string Width = textBoxWidth.Text;

            if (double.TryParse(Hight, out hight))
            {
                if(hight<2)
                {
                    this.Close();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                
                else
                {
                    this.Close();
                    if (double.TryParse(Width, out width))
                    {
                        if (width < 0 || width == 0)
                        {
                            this.Close();
                            Form3 form3 = new Form3();
                            form3.Show();
                        }

                        else
                        {
                            this.Close();
                            area = width * hight;
                            circumference = 2 * (width + hight);
                            difference = Math.Abs(width - hight);


                            if (width == hight || difference > 5)
                            {
                                solution = area;
                            }
                            else
                            {
                                solution = circumference;
                            }
                            string SolutionString = solution.ToString();
                            resultRectangular resultform = new resultRectangular();
                            resultform.resultstring = SolutionString;
                            resultform.Show();


                        }
                    }

                    else
                    {
                        this.Close();
                        Form3 form3 = new Form3();
                        form3.Show();
                    }


                }
               
            }
            else
            {
                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
                
            }
          
            


        }
    }
}
