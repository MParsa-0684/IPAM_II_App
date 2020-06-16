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
    public partial class Form9 : Form
    {
        public int turn = 0;
        public string save;
        public bool Win = false;
        int i;
        int j;
        public Form9()
        {
            InitializeComponent();
            b_1_1_.Text = "";
            b_1_2_.Text = "";
            b_1_3_.Text = "";
            b_2_1_.Text = "";
            b_2_2_.Text = "";
            b_2_3_.Text = "";
            b_3_1_.Text = "";
            b_3_2_.Text = "";
            b_3_3_.Text = "";

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            O.Text = "";
            X.Text = "";
            label8.Text = "";

            turn = Convert.ToInt32(label1.Text);
            turn = turn + 1;
            label1.Text = turn.ToString();
            if (turn % 2 == 0)
            {
                ((Button)sender).Text = "X";
                ((Button)sender).BackColor = Color.DarkRed;
                O.Text = "     Your Turn .";


            }
            if (turn % 2 == 1)
            {
                ((Button)sender).Text = "O";
                ((Button)sender).BackColor = Color.DarkGreen;
                X.Text = "     Your Turn .";

            }
             ((Button)sender).Enabled = false;
            if((b_1_1_.Text=="X"&&b_1_2_.Text=="X"&&b_1_3_.Text=="X") || (b_1_1_.Text == "O" && b_1_2_.Text == "O" && b_1_3_.Text == "O"))
            {
                if (b_1_1_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_1_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_2_1_.Text=="X"&&b_2_2_.Text=="X"&&b_2_3_.Text=="X")||(b_2_1_.Text == "O" && b_2_2_.Text == "O" && b_2_3_.Text == "O"))
            {
                if (b_2_1_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_2_1_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_3_1_.Text=="X"&&b_3_2_.Text=="X"&&b_3_3_.Text=="X")||(b_3_1_.Text == "O" && b_3_2_.Text == "O" && b_3_3_.Text == "O"))
            {
                if (b_3_1_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_3_1_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_1_1_.Text=="X"&&b_2_1_.Text=="X"&&b_3_1_.Text=="X")||(b_1_1_.Text == "O" && b_2_1_.Text == "O" && b_3_1_.Text == "O"))
            {
                if (b_1_1_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_1_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_1_2_.Text=="X"&&b_2_2_.Text=="X"&&b_3_2_.Text=="X")||(b_1_2_.Text == "O" && b_2_2_.Text == "O" && b_3_2_.Text == "O"))
            {
                if (b_1_2_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_2_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_1_3_.Text=="X"&&b_2_3_.Text=="X"&&b_3_3_.Text=="X")||(b_1_3_.Text == "O" && b_2_3_.Text == "O" && b_3_3_.Text == "O"))
            {
                if (b_1_3_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_3_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_1_1_.Text=="X"&&b_2_2_.Text=="X"&&b_3_3_.Text=="X")|| (b_1_1_.Text == "O" && b_2_2_.Text == "O" && b_3_3_.Text == "O"))
            {
                if (b_1_1_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_1_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
            }
            if((b_1_3_.Text=="X"&&b_2_2_.Text=="X"&&b_3_1_.Text=="X")|| (b_1_3_.Text == "O" && b_2_2_.Text == "O" && b_3_1_.Text == "O"))
            {
                if (b_1_3_.Text == "X")
                {
                    MessageBox.Show("  You won " + textBox1.Text, "Congratulations");
                    Disable();
                    Win = true;
                }
                if (b_1_3_.Text == "O")
                {
                    MessageBox.Show("  You won " + textBox2.Text, "Congratulations");
                    Disable();
                    Win = true;
                }

            }
            if (Win == true)
            {
                X.Text = "     Game Finishid .";
                O.Text = "     Game Finishid .";
            }
            if (turn == 9 && Win == false)
            {
                MessageBox.Show("   The game equalised !", "Information");
            }
        }
        private void Disable()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;

                }

            }
            catch
            {

            }
        }

        private void switchPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            b_1_1_.Text = "";
            b_1_1_.Enabled = true;
            b_1_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_2_.Text = "";
            b_1_2_.Enabled = true;
            b_1_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_3_.Text = "";
            b_1_3_.Enabled = true;
            b_1_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_1_.Text = "";
            b_2_1_.Enabled = true;
            b_2_1_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            b_2_2_.Text = "";
            b_2_2_.Enabled = true;
            b_2_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_3_.Text = "";
            b_2_3_.Enabled = true;
            b_2_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_1_.Text = "";
            b_3_1_.Enabled = true;
            b_3_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_2_.Text = "";
            b_3_2_.Enabled = true;
            b_3_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_3_.Text = "";
            b_3_3_.Enabled = true;
            b_3_3_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            save = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = save;
            Win = false;
            O.Text = "You will start .";
            X.Text = "";
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            b_1_1_.Text = "";
            b_1_1_.Enabled = true;
            b_1_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_2_.Text = "";
            b_1_2_.Enabled = true;
            b_1_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_3_.Text = "";
            b_1_3_.Enabled = true;
            b_1_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_1_.Text = "";
            b_2_1_.Enabled = true;
            b_2_1_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            b_2_2_.Text = "";
            b_2_2_.Enabled = true;
            b_2_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_3_.Text = "";
            b_2_3_.Enabled = true;
            b_2_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_1_.Text = "";
            b_3_1_.Enabled = true;
            b_3_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_2_.Text = "";
            b_3_2_.Enabled = true;
            b_3_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_3_.Text = "";
            b_3_3_.Enabled = true;
            b_3_3_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            Win = false;
            O.Text = "You will start .";
            X.Text = "";
        }

        private void newPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            b_1_1_.Text = "";
            b_1_1_.Enabled = true;
            b_1_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_2_.Text = "";
            b_1_2_.Enabled = true;
            b_1_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_1_3_.Text = "";
            b_1_3_.Enabled = true;
            b_1_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_1_.Text = "";
            b_2_1_.Enabled = true;
            b_2_1_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            b_2_2_.Text = "";
            b_2_2_.Enabled = true;
            b_2_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_2_3_.Text = "";
            b_2_3_.Enabled = true;
            b_2_3_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_1_.Text = "";
            b_3_1_.Enabled = true;
            b_3_1_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_2_.Text = "";
            b_3_2_.Enabled = true;
            b_3_2_.BackColor = ColorTranslator.FromHtml("#046D8F");
            b_3_3_.Text = "";
            b_3_3_.Enabled = true;
            b_3_3_.BackColor = ColorTranslator.FromHtml("#046D8F"); ;
            textBox1.Text = "";
            textBox2.Text = "";
            X.Text = "Please write your name .";
            O.Text = "Please write your name . ";
            label8.Text = "You will start .";
            Win = false;
        }
    }
}
