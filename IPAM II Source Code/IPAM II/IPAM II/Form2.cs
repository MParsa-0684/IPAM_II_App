﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
