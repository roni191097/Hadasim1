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
    public partial class Form2triangle : Form
    {
        public double hight = 0;
        public double length = 0;
        public double circumference = 0;
        public double side = 0;
        public string draw="";


        public Form2triangle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hight = textBoxHight.Text;
            string Width = textBoxWidth.Text;

            if (double.TryParse(Hight, out hight))
            {
                if (hight < 2)
                {
                    this.Close();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    this.Close();
                    if (double.TryParse(Width, out length))
                    {
                        if (length < 0 || length == 0)
                        {
                            this.Close();
                            Form3 form3 = new Form3();
                            form3.Show();
                        }

                        else
                        {
                            this.Close();
                            pythagorean();
                            circumference = 2 * side + length;
                            string circumferenceString = circumference.ToString();
                            resulttrinagle resultREC = new resulttrinagle();
                            resultREC.cir = circumferenceString;
                            if(even()||check_islargest())
                            {
                                resultREC.drawing = "cant draw";
                                //להמשיך מהחלק של הציור 

                            }
                            else
                            {
                                print();
                                resultREC.drawing = draw;

                            }
                            resultREC.Show();


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

        public double pythagorean()
        {

            double pow = Math.Pow(0.5 * length, 2) + Math.Pow(hight, 2);
            side = Math.Sqrt(pow);
            return side;
        }

        public bool even()
        {
            if (side % 2 == 0)
                return true;
            else
                return false;
        }

        public bool check_islargest()
        {
            if (side > 2 * hight)
                return true;
            else
                return false;
        }

        public string print()
        {
            double midLines = hight - 2;
            int numOfOdd = 0;
            int sideInt = (int)side;
            for(int i=(int) length-2;i>1;i-=2)
            {
                numOfOdd++;
            }
            double repetition = midLines / numOfOdd;
            draw="*\n";
            double repitionDown = Math.Floor(repetition);
            double sumofRep = repitionDown * (numOfOdd-1);
            double repitionUp = midLines - sumofRep;
            
            for (int i = 0; i < repitionUp; i++)
            {
                draw += "***\n";
            }
            
            

        
            for (int i = 5; i < length; i += 2)
            {
                string star = "";
                for (int j=i;j>0;j--)
                {
                     star+= "*";
                }
                for (int f = 0; f < repitionDown; f++)
                {
                    draw += star+"\n";

                }

            }

            for (int hight = (int)length; hight > 0; hight--)
            {
                draw += "*";
            }
            



            return draw;
        }


    }
}
