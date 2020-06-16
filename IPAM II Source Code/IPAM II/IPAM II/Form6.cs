using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPAM_II
{
    public partial class Form6 : Form
    {
        public double NU = 0;
        public string f;
        public double nu = 0;
        public string st = " ";
        public double r;
        public string mark = "";
        public double answer = 0;
        public double Nu;
        public double t;
        public string L = "";
        public string Memory = "";
        public double MEMORY = 0;
        public double memory = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }


        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button2.Text;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button3.Text;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button6.Text;
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button7.Text;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button8.Text;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button9.Text;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "";
                r = 1;
            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button10.Text;
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (L == "=")
            {
                // Nu = 0;
                label1.Text = "";
                L = "";
            }
            if (L == "")
            {
                label1.Text = label1.Text + textBox1.Text + "+";
                if (mark == "+")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu + Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "-")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu - Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "*")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu * Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "/")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu / Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "")
                {
                    nu = double.Parse(textBox1.Text);
                    mark = "+";
                }
                mark = "+";
                // textBox1.Text = "";
                r = 0;
                //  st = NU.ToString();
                // textBox1.Text = st;

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                // label1.Text = label1.Text + "+"+ textBox1.Text ;
                if (L == "=")
                {
                    label1.Text = "";
                    L = "";
                }
                if (L == "")
                {
                    label1.Text = label1.Text + textBox1.Text + "-";
                    if (mark == "+")
                    {
                        Nu = Convert.ToDouble(textBox1.Text);
                        nu = nu + Nu;
                        textBox1.Text = nu.ToString();
                        //  mark = "/";

                    }
                    if (mark == "-")
                    {
                        Nu = Convert.ToDouble(textBox1.Text);
                        nu = nu - Nu;
                        textBox1.Text = nu.ToString();
                        //  mark = "/";

                    }
                    if (mark == "*")
                    {
                        Nu = Convert.ToDouble(textBox1.Text);
                        nu = nu * Nu;
                        textBox1.Text = nu.ToString();
                        // mark = "/";

                    }
                    if (mark == "/")
                    {
                        Nu = Convert.ToDouble(textBox1.Text);
                        nu = nu / Nu;
                        textBox1.Text = nu.ToString();
                        // mark = "/";

                    }
                    if (mark == "")
                    {
                        nu = double.Parse(textBox1.Text);
                        mark = "-";
                    }

                    mark = "-";
                    // textBox1.Text = "";
                    r = 0;
                    //  st = NU.ToString();
                    // textBox1.Text = st;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // label1.Text = label1.Text + "+"+ textBox1.Text ;
            if (L == "=")
            {
                label1.Text = "";
                L = "";
            }
            if (L == "")
            {

                label1.Text = label1.Text + textBox1.Text + "×";
                if (mark == "+")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu + Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "-")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu - Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "*")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu * Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "/")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu / Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "")
                {
                    nu = double.Parse(textBox1.Text);
                    mark = "*";
                }
                mark = "*";
                // textBox1.Text = "";
                r = 0;
                //  st = NU.ToString();
                // textBox1.Text = st;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // label1.Text = label1.Text + "+"+ textBox1.Text ;
            if (L == "=")
            {
                label1.Text = "";
                L = "";
            }
            if (L == "")
            {

                label1.Text = label1.Text + textBox1.Text + "÷";
                if (mark == "+")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu + Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "-")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu - Nu;
                    textBox1.Text = nu.ToString();
                    //  mark = "/";

                }
                if (mark == "*")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu * Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "/")
                {
                    Nu = Convert.ToDouble(textBox1.Text);
                    nu = nu / Nu;
                    textBox1.Text = nu.ToString();
                    // mark = "/";

                }
                if (mark == "")
                {
                    nu = double.Parse(textBox1.Text);
                    mark = "/";
                }
                mark = "/";
                // textBox1.Text = "";
                r = 0;
                //  st = NU.ToString();
                // textBox1.Text = st;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + textBox1.Text;
            NU = Convert.ToDouble(textBox1.Text);
            if (mark == "+")
            {
                nu = nu + NU;
                textBox1.Text = nu.ToString();
            }
            if (mark == "-")
            {
                nu = nu - NU;
                textBox1.Text = nu.ToString();
            }
            if (mark == "*")
            {
                nu = nu * NU;
                textBox1.Text = nu.ToString();
            }
            if (mark == "/")
            {
                nu = nu / NU;
                textBox1.Text = nu.ToString();
            }
            label1.Text = label1.Text + "=" + textBox1.Text;
            r = 0;
            L = "=";
            mark = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            NU = 0;
            nu = 0;
            r = 0;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            r = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
            MEMORY = MEMORY + memory;
            //   textBox1.Text = MEMORY.ToString();
            label4.Text = "Memory Value : "+MEMORY.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
            MEMORY = MEMORY - memory;
            //  textBox1.Text = MEMORY.ToString();
            label4.Text = "Memory Value : " + MEMORY.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = MEMORY.ToString();
            label4.Text = "Memory Value : " + MEMORY.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MEMORY = 0;
            label4.Text = "Memory Value : " + MEMORY.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                textBox1.Text = "0";
                r = 1;

            }
            if (r == 1)
            {
                textBox1.Text = textBox1.Text + button21.Text;
            }

        }
    }
   }
     