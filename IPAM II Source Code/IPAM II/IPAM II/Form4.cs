using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace IPAM_II
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            label16.Font = new Font("Cambria", 15, FontStyle.Bold);
            label16.Location = new Point(610, 60);
            if(textBox3.Text==null || textBox3.Text == "") { textBox3.Text = " "; }
            if(textBox4.Text == null || textBox4.Text == "") { textBox4.Text = " "; }
            if (textBox5.Text == null || textBox5.Text == "") { textBox5.Text = " "; }
            if (textBox6.Text == null || textBox6.Text == "") { textBox6.Text = " "; }

            label16.Text = textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text+"\n"+textBox5.Text+"\n"+textBox6.Text;
            if (comboBox1.SelectedItem == "Laughing") { pictureBox1.Image = IPAM_II.Properties.Resources._1; }
            if (comboBox1.SelectedItem == "Sleeping") { pictureBox1.Image = IPAM_II.Properties.Resources._2; }
            if (comboBox1.SelectedItem == "Crying") { pictureBox1.Image = IPAM_II.Properties.Resources._3; }
            if (comboBox1.SelectedItem == "Celebrating") { pictureBox1.Image = IPAM_II.Properties.Resources._4; }
            if (comboBox1.SelectedItem == "Embarrassed") { pictureBox1.Image = IPAM_II.Properties.Resources._5; }
            if (comboBox1.SelectedItem == "Agreeing") { pictureBox1.Image = IPAM_II.Properties.Resources._6; }
            if (comboBox1.SelectedItem == "Victory") { pictureBox1.Image = IPAM_II.Properties.Resources._7; }
            if (comboBox1.SelectedItem == "Thinking") { pictureBox1.Image = IPAM_II.Properties.Resources._8; }
            if (comboBox1.SelectedItem == "Explaining") { pictureBox1.Image = IPAM_II.Properties.Resources._9; }
            if (comboBox1.SelectedItem == "Thanking") { pictureBox1.Image = IPAM_II.Properties.Resources._10; }
            if (comboBox1.SelectedItem == "Greeting") { pictureBox1.Image = IPAM_II.Properties.Resources._11; }
            if (comboBox1.SelectedItem == "Confused") { pictureBox1.Image = IPAM_II.Properties.Resources._12; }
            if (comboBox1.SelectedItem == "Regretting") { pictureBox1.Image = IPAM_II.Properties.Resources._13; }
            if (comboBox1.SelectedItem == "Sad") { pictureBox1.Image = IPAM_II.Properties.Resources._14; }
            if (comboBox1.SelectedItem == "Energetic") { pictureBox1.Image = IPAM_II.Properties.Resources._15; }
            if (comboBox1.SelectedItem == "Happy to meet") { pictureBox1.Image = IPAM_II.Properties.Resources._16; }
            if (comboBox1.SelectedItem == "Cooperation") { pictureBox1.Image = IPAM_II.Properties.Resources._17; }
            if (comboBox1.SelectedItem == "Being Quiet") { pictureBox1.Image = IPAM_II.Properties.Resources._18; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == null || textBox3.Text == "") { textBox3.Text = " "; }
            if (textBox4.Text == null || textBox4.Text == "") { textBox4.Text = " "; }
            if (textBox5.Text == null || textBox5.Text == "") { textBox5.Text = " "; }
            if (textBox6.Text == null || textBox6.Text == "") { textBox6.Text = " "; }
            string IPAMIIKnowledge = "IPAM II Knowledge.txt";
            using (StreamWriter SW = File.AppendText(IPAMIIKnowledge))
            {
                SW.WriteLine();
                SW.Write(textBox1.Text + "," + textBox2.Text + "_" + textBox3.Text + "_" +textBox4.Text+"_"+textBox5.Text+"_"+textBox6.Text+"_,"+comboBox1.SelectedItem+",");
                SW.Close();
            }
            Close();
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
