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
    public partial class Form11 : Form
    {
        int hours=0;
        int minutes=0;
        int seconds=0;
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(comboBox1.SelectedItem);
            minutes = Convert.ToInt32(comboBox2.SelectedItem);
            seconds = Convert.ToInt32(comboBox3.SelectedItem);
            if (hours < 10)
            {
                label1.Text = "0" + Convert.ToString(hours);
            }
            else
            {
                label1.Text = Convert.ToString(hours);
            }
            if (minutes < 10)
            {
                label2.Text = "0" + Convert.ToString(minutes);
            }
            else
            {
                label2.Text = Convert.ToString(minutes);
            }
            if (seconds < 10)
            {
                label3.Text = "0" + Convert.ToString(seconds);
            }
            else
            {
                label3.Text = Convert.ToString(seconds);
            }
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(label1.Text);
            minutes = Convert.ToInt32(label2.Text);
            seconds = Convert.ToInt32(label3.Text);
            if (seconds > 0)
            {
                seconds--;
                if (seconds < 10)
                {
                    label3.Text = "0" + Convert.ToString(seconds);
                }
                else
                {
                    label3.Text = Convert.ToString(seconds);
                }

            }
            else
            {
                if (minutes > 0)
                {
                    minutes--;
                    seconds = 60;
                    seconds--;
                    if (minutes < 10)
                    {
                        label2.Text = "0" + Convert.ToString(minutes);
                    }
                    else
                    {
                        label2.Text = Convert.ToString(minutes);
                    }
                    if (seconds < 10)
                    {
                        label3.Text = "0" + Convert.ToString(seconds);
                    }
                    else
                    {
                        label3.Text = Convert.ToString(seconds);
                    }

                }
                else
                {
                    if (hours > 0)
                    {
                        hours--;
                        minutes = 60;
                        minutes--;
                        seconds = 60;
                        seconds--;
            if (hours < 10)
            {
                label1.Text = "0" + Convert.ToString(hours);
            }
            else
            {
                label1.Text = Convert.ToString(hours);
            }
            if (minutes < 10)
            {
                label2.Text = "0" + Convert.ToString(minutes);
            }
            else
            {
                label2.Text = Convert.ToString(minutes);
            }
            if (seconds < 10)
            {
                label3.Text = "0" + Convert.ToString(seconds);
            }
            else
            {
                label3.Text = Convert.ToString(seconds);
            }

                    }
                    else
                    {
                        timer1.Enabled = false;
                    }
                }
            }
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }
    }
}
