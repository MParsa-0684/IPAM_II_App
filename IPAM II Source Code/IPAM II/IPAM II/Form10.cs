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
    public partial class Form10 : Form
    {
        int mms=0;
        int s=0;
        int m=0;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mms = 0;
            int s = 0;
            int m = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "0";
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mms = Convert.ToInt32(label3.Text);
            mms++;
            if (mms == 10)
            {
                s = Convert.ToInt32(label2.Text);
                s++;
                if (s < 10)
                {
                    label2.Text = "0" + Convert.ToString(s);
                }
                else
                {
                    label2.Text = Convert.ToString(s);
                }
                if (s == 60)
                {
                    m = Convert.ToInt32(label1.Text);
                    m++;
                    if (m < 100)
                    {
                        if (m < 10)
                        {
                            label1.Text = "0" + Convert.ToString(m);
                        }
                        else
                        {
                            label1.Text = Convert.ToString(m);
                        }
                    }
                    label2.Text = "00";
                    s = 0;
                }

                mms = 0;
                label3.Text = Convert.ToString(mms);
            }
            else
            {
                label3.Text = Convert.ToString(mms);
            }
            button2.Enabled = true;
        }
    }
}
