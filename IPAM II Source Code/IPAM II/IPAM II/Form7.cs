using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace IPAM_II
{
    public partial class Form7 : Form
    {
        Timer timerh = new Timer();
        Timer timerm = new Timer();
        Timer timers = new Timer();
        Timer timert = new Timer();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH");
            label2.Text = DateTime.Now.ToString("mm");
            label3.Text = DateTime.Now.ToString("ss");
            label4.Text = DateTime.Now.ToString("tt");
            timerh.Tick += new EventHandler(timer_H);
            timerm.Tick += new EventHandler(timer_m);
            timers.Tick += new EventHandler(timer_s);
            timert.Tick += new EventHandler(timer_t);
            timerh.Interval = 500;
            timerm.Interval = 500;
            timers.Interval = 500;
            timert.Interval = 500;
            timerh.Start();
            timerm.Start();
            timers.Start();
            timert.Start();


        }
        private void timer_H(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH");
        }
        private void timer_m(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("mm");
        }
        private void timer_s(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("ss");
        }
        private void timer_t(object sender, EventArgs e)
        {

            label4.Text = DateTime.Now.ToString("tt");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exchangigColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == DateTime.Now.ToString("HH"))
            {
                label1.Text = "00";
                timerh.Enabled = false;
            }
            else
            {
                timerh.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == DateTime.Now.ToString("mm"))
            {
                label2.Text = "00";
                timerm.Enabled = false;
            }
            else
            {
                timerm.Enabled = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == DateTime.Now.ToString("ss"))
            {
                label3.Text = "00";
                timers.Enabled = false;
            }
           else
            {
                timers.Enabled = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == DateTime.Now.ToString("tt"))
            {
                label4.Text = "- -";
                timert.Enabled = false;
            }
            else
            {
                timert.Enabled = true;
            }

        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == ColorTranslator.FromHtml("#C1EFFF") && menuStrip1.BackColor == ColorTranslator.FromHtml("#046D8F"))
            {
                this.BackColor = ColorTranslator.FromHtml("#046D8F");
                menuStrip1.BackColor = ColorTranslator.FromHtml("#C1EFFF");

            }
            //if (this.BackColor == ColorTranslator.FromHtml("#046D8F") && menuStrip1.BackColor == ColorTranslator.FromHtml("#C1EFFF"))
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#C1EFFF");
                menuStrip1.BackColor = ColorTranslator.FromHtml("#046D8F");

            }

        }
    }
}
