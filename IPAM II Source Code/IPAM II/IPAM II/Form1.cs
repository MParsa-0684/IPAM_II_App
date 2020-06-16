using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Diagnostics;


namespace IPAM_II
{
    public partial class Form1 : Form
    {
        string Line;
        string UserText;
        string IPAMIIText;
        bool knowledge;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void IPAM(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 54
            pictureBox1.Image = IPAM_II.Properties.Resources._9;
            label1.Text = "Welcome to IPAM II ! \nYour Constant Friend ! \nI'm an Artificial Intelligence !";
            label1.Font = new Font("Cambria", 15, FontStyle.Bold);
            label1.Location = new Point(50,88);
            timer1.Enabled = false;
            timer3.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = "How can I help you ?";
            pictureBox1.Image = IPAM_II.Properties.Resources._8;
            timer3.Enabled = false;
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IPAMIIKnowledge = "IPAM II Knowledge.txt";
            knowledge = false;
            IPAMIIText = "";
            UserText = textBox1.Text;
            UserText = UserText.ToLower();
            if(UserText.Contains("what time is it") ||UserText.Contains("what is today's date"))
            {
                label1.Text = "Today's Date & Time :\n              "+DateTime.Now.ToString();
                pictureBox1.Image = IPAM_II.Properties.Resources._9;

            }
            else
            {
                using (StreamReader SR = new StreamReader(IPAMIIKnowledge))
                {
                    if (UserText == "" || UserText == null)
                    {
                        label1.Text = "You sent Null message !";
                        pictureBox1.Image = IPAM_II.Properties.Resources._5;
                        knowledge = true;
                    }
                    while (!SR.EndOfStream)
                    {

                        Line = SR.ReadLine();
                        string[] items = Line.Split('$');
                        items[0] = items[0].ToLower();
                        if (UserText.Contains(items[0]))
                        {
                            string[] parts = items[1].Split('_');
                            IPAMIIText = parts[0] + "\n" + parts[1] + "\n" + parts[2] + "\n" + parts[3] + "\n" + parts[4];
                            setImage(items[2]);
                            label1.Text = IPAMIIText;
                            knowledge = true;
                            break;
                        }

                    }
                    if (knowledge == false)
                    {
                        label1.Text = "Unfortunately, \nI can't understand your message ! \nCan you please teach it to me ? \nYou can teach me \n                    in <Teach to IPAM II> Part.";
                        pictureBox1.Image = IPAM_II.Properties.Resources._12;

                    }
                }
            }
        
        }
        public void setImage (string feeling)
        {
            if (feeling == "Laughing") { pictureBox1.Image = IPAM_II.Properties.Resources._1; }
            if (feeling == "Sleeping") { pictureBox1.Image = IPAM_II.Properties.Resources._2; }
            if (feeling == "Crying") { pictureBox1.Image = IPAM_II.Properties.Resources._3; }
            if (feeling == "Celebrating") { pictureBox1.Image = IPAM_II.Properties.Resources._4; }
            if (feeling == "Embarrassed") { pictureBox1.Image = IPAM_II.Properties.Resources._5; }
            if (feeling == "Agreeing") { pictureBox1.Image = IPAM_II.Properties.Resources._6; }
            if (feeling == "Victory") { pictureBox1.Image = IPAM_II.Properties.Resources._7; }
            if (feeling == "Thinking") { pictureBox1.Image = IPAM_II.Properties.Resources._8; }
            if (feeling == "Explaining") { pictureBox1.Image = IPAM_II.Properties.Resources._9; }
            if (feeling == "Thanking") { pictureBox1.Image = IPAM_II.Properties.Resources._10; }
            if (feeling == "Greeting") { pictureBox1.Image = IPAM_II.Properties.Resources._11; }
            if (feeling == "Confused") { pictureBox1.Image = IPAM_II.Properties.Resources._12; }
            if (feeling == "Regretting") { pictureBox1.Image = IPAM_II.Properties.Resources._13; }
            if (feeling == "Sad") { pictureBox1.Image = IPAM_II.Properties.Resources._14; }
            if (feeling == "Energetic") { pictureBox1.Image = IPAM_II.Properties.Resources._15; }
            if (feeling == "Happy to meet") { pictureBox1.Image = IPAM_II.Properties.Resources._16; }
            if (feeling == "Cooperation") { pictureBox1.Image = IPAM_II.Properties.Resources._17; }
            if (feeling == "Being Quiet") { pictureBox1.Image = IPAM_II.Properties.Resources._18; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            label1.Text = "You have opened Calculator App at \n                                                 " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._15;

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            label1.Text = "You have opened Calender App at \n                                               " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._15;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            label1.Text = "You have opened Clock App at \n                                      " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._6;

        }

        private void label25_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            label1.Text = "You have opened StopWatch App at \n                                                  " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._10;

        }

        private void label26_Click(object sender, EventArgs e)
        {
            label1.Text = "You have opened Tic Tac Toe App \n                                        at " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._10;
            Form9 form9 = new Form9();
            form9.Show();

        }

        private void label21_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            label1.Text = "You have opened Quizes App at \n                                          " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._6;

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            label1.Text = "You have opened Notes App at \n                                      " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._6;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            label1.Text = "You have opened Tasks App at \n                                      " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._10;

        }

        private void label22_Click(object sender, EventArgs e)
        {
            label1.Text = "You have opened Teach to IPAM II\n                              App at " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._10;
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            label1.Text = "You have opened Othello App at \n                                           " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._9;


        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            label1.Text = "You have opened Web App at \n                                     " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._6;

        }

        private void label19_Click(object sender, EventArgs e)
        {
            label1.Text = "You have opened Timer App at \n                                       " + DateTime.Now.ToString("HH:mm:ss tt");
            pictureBox1.Image = IPAM_II.Properties.Resources._16;
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void appsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Developer of this Program is Mohammad Parsa Mahmoudabadi Arani !\nHe developed it when he was 15.\nThis Program contains many Apps & an A.I. called IPAM II.\nThis Program has an older version called IPAM I.\nThis Program developed in 2021.", "About Developer");
        }

        private void aboutIPAMIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program is a Project to Help People to do their regular words easily.\nThis Program Called IPAM II; The second version of IPAM Apps.\nThis Program was developed by Mohammad Parsa Mahmoudabadi Arani in 2021.", "About IPAM II");
        }

        private void openToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Process.Start("IPAM I.exe");
            label1.Text = "Welcome to IPAM I !\nMy older version ...";
            pictureBox1.Image = IPAM_II.Properties.Resources._10;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Calculate your datas with this App.", "Calculator Help"); ;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can Add your Events in Calender with Date & Time.\nNote :\n1.Don't type about your event more than the borders.\n2.Try to full all FOUR lines.", "Calender Help");
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can see time in this App.\nYou can change Hour/Minute/Second/AM.PM to null to customize your clock.\nYou also can Change the Theme of your clock.", "Clock Help");
        }

        private void helpToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can type & save your notes in this App.\nNote :\n1.After Saving/Deleting/Changing Fonts & Colors/Typing your Note/Changing Note Name, Please Close the App & Reopen it.", "Notes Help");
        }

        private void helpToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can make Quizes by Adding questions in this App.\nNote : \n1.You can lock and Unlock your quize by clicking it's Button for times.", "Quizes Help");
        }

        private void helpToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use this app easily !", "StopWatch Help");
        }

        private void helpToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can add your To Do Tasks & Complete them !", "Tasks Help");
        }

        private void helpToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Teach to IPAM II & Increase his knowledge !", "Teach to IPAM II Help");
        }

        private void helpToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can play Tic Tac Toe & Enjoy !", "Tic Tac Toe Help");
        }

        private void helpToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use Timer App very easily !", "Timer Help");
        }

        private void helpToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can surf the net & Save the URL that you interested in & Use that URL again.", "Web Help");
        }

        private void helpToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can play Othello & Enjoy !", "Othello Help");
        }
    }
}
