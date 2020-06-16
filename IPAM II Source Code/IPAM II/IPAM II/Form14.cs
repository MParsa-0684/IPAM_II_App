using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace IPAM_II
{

    public partial class Form14 : Form
    {
        ArrayList labels = new ArrayList();
        ArrayList buttons = new ArrayList();
        ArrayList buttons2 = new ArrayList();
        ArrayList comboboxes = new ArrayList();
        ArrayList answers = new ArrayList();
        int l;
        int n = 0;
        int y;
        int ly;
        int mi;
        int b2y;
        int cy;
        int counter = 0;
        string QuestionsSave = "Questions.txt";
        bool first = false;
        string alltext = "";
        string labeldeleted = "";
        bool ans = false;
        int f;

        public Form14()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            b_1.Text = "✔";
            b_2.Text = " ";
            b_3.Text = " ";
            b_4.Text = " ";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            b_1.Text = " ";
            b_2.Text = "✔";
            b_3.Text = " ";
            b_4.Text = " ";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            b_1.Text = " ";
            b_2.Text = " ";
            b_3.Text = "✔";
            b_4.Text = " ";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            b_1.Text = " ";
            b_2.Text = " ";
            b_3.Text = " ";
            b_4.Text = "✔";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Button button = new Button();
            Button button22 = new Button();
            ComboBox combobox = new ComboBox();
            label.Text =textBox1.Text;
            button.Text = "×";
            button22.Text = "Send";
            combobox.Items.Add(textBox2.Text);
            combobox.Items.Add(textBox3.Text);
            combobox.Items.Add(textBox4.Text);
            combobox.Items.Add(textBox5.Text);
            combobox.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
            label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
            button22.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
            label.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
            combobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
            button22.BackColor = System.Drawing.ColorTranslator.FromHtml("#046D8F");
            button.BackColor = System.Drawing.Color.DarkRed;
            combobox.Size = new Size(textBox4.Size.Width, textBox4.Size.Height);
            label.Size = new Size(textBox1.Size.Width, textBox1.Size.Height);
            button22.Size = new Size(80, textBox4.Size.Height);
            button.Size = new System.Drawing.Size(40, 73);
            label.ForeColor = Color.Black;
            combobox.ForeColor = Color.Black;
            if (buttons.Count > 0)
            {
                button.Location = new Point(26, l +  80);
                label.Location = new Point(73, l + 80);
                combobox.Location = new Point(75, l + 120);
                button22.Location = new Point(combobox.Location.X + combobox.Size.Width + 10, l + 120);
                l = label.Location.Y;

            }
            else
            {
                button.Location = new Point(26, 340);
                label.Location = new Point(73, 340);
                combobox.Location = new Point(75, 380);
                button22.Location = new Point(combobox.Location.X + combobox.Size.Width + 10, 378);
                l = 340;
            }
            this.label3.Location = new Point(this.label3.Location.X, this.label3.Location.Y + 80);
            if (b_1.Text == "✔")
            {
                answers.Add(textBox2.Text);
            }
            if (b_2.Text == "✔")
            {
                answers.Add(textBox3.Text);
            }
            if (b_3.Text == "✔")
            {
                answers.Add(textBox4.Text);
            }
            if (b_4.Text == "✔")
            {
                answers.Add(textBox5.Text);
            }
            Controls.Add(label);
            Controls.Add(button);
            Controls.Add(combobox);
            Controls.Add(button22);
            labels.Add(label);
            buttons.Add(button);
            comboboxes.Add(combobox);
            buttons2.Add(button22);
            button.Click += new EventHandler(button_Click);
            button22.Click += new EventHandler(button22_Click);

        }
        private void button_Click(object sender, EventArgs e)
        {
            mi = 0;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] == ((Button)sender))
                {
                    y = ((Button)sender).Location.Y;
                    Controls.Remove((Button)sender);
                    buttons.Remove(((Button)sender));
                    foreach (Label label in labels)
                    {
                        if (label == labels[i])
                        {
                            ly = label.Location.Y;
                            Controls.Remove(label);
                            labels.Remove(label);
                            break;
                        }

                    }
                    foreach(Button button in buttons2)
                    {
                        if(button == buttons2[i])
                        {
                            b2y = button.Location.Y;
                            Controls.Remove(button);
                            buttons2.Remove(button);
                            break;
                        }
                    }
                    foreach(ComboBox combobox in comboboxes)
                    {
                        if(combobox == comboboxes[i])
                        {
                            cy = combobox.Location.Y;
                            Controls.Remove(combobox);
                            comboboxes.Remove(combobox);
                            break;
                        }
                    }
                    answers.Remove(answers[i]);
                    n = i;
                    break;
                }
            }
            foreach (Button button in buttons)
            {
                if (button.Location.Y > y)
                {

                    button.Location = new Point(button.Location.X, button.Location.Y - 80);

                }
            }
            foreach (Label label in labels)
            {
                if (label.Location.Y > y)
                {
                    label.Location = new Point(label.Location.X, label.Location.Y - 80);
                    l = label.Location.Y;
                    label3.Location = new Point(label3.Location.X, label3.Location.Y - 80);

                }
            }
            foreach (Button button in buttons2)
            {
                if (button.Location.Y > y)
                {

                    button.Location = new Point(button.Location.X, button.Location.Y - 80);

                }
            }
            foreach (ComboBox combobox in comboboxes)
            {
                if (combobox.Location.Y > y)
                {

                    combobox.Location = new Point(combobox.Location.X, combobox.Location.Y - 80);

                }
            }
            if (l == y)
            {
                l = l - 80;
            }

        }
        private void button22_Click(object sender, EventArgs e)
        {
            ans = false;
            for (int i = 0; i < buttons2.Count; i++)
            {
                if (buttons2[i] == ((Button)sender))
                {
                    foreach (ComboBox combobox in comboboxes)
                    {
                        if (comboboxes[i] == combobox)
                        {
                            if (Convert.ToString(combobox.SelectedItem) == Convert.ToString(answers[i]))
                            {
                                f = i;
                                ans = true;
                                break;
                            }
                            f = i;
                        }
                    }

                }
            }

            if (ans == true)
            {
                foreach (Label label in labels)
                {
                    if (labels[f] == label)
                    {
                        label.Text = label.Text + " ✔"; break;
                    }
                }
            }
            else
            {
                foreach (Label label in labels)
                {
                    if (labels[f] == label)
                    {
                        label.Text = label.Text + " ❌"; break;
                    }
                }

            }

            ((Button)sender).Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                counter++;
            }
            else
            {
                if (button1.Text == "Lock")
                {
                    button1.Text = "Unlock";
                    button2.Enabled = false;
                    foreach(Button button in buttons)
                    {
                        button.Enabled = false;
                    }
                }
                else
                {
                    button1.Text = "Lock";
                    button2.Enabled = true;
                    foreach(Button button in buttons)
                    {
                        button.Enabled = true;
                    }
                }
                counter = 0; 
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            using(StreamReader SR = new StreamReader(QuestionsSave))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if(line != "")
                    {
                        Label label = new Label();
                        Button button = new Button();
                        Button button22 = new Button();
                        ComboBox combobox = new ComboBox();
                        string[] parts = line.Split('#');
                        label.Text = parts[0];
                        button.Text = "×";
                        button22.Text = "Send";
                        combobox.Items.Add(parts[1]);
                        combobox.Items.Add(parts[2]);
                        combobox.Items.Add(parts[3]);
                        combobox.Items.Add(parts[4]);
                        combobox.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
                        label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
                        button22.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
                        label.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
                        combobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
                        button22.BackColor = System.Drawing.ColorTranslator.FromHtml("#046D8F");
                        button.BackColor = System.Drawing.Color.DarkRed;
                        combobox.Size = new Size(textBox4.Size.Width, textBox4.Size.Height);
                        label.Size = new Size(textBox1.Size.Width, textBox1.Size.Height);
                        button22.Size = new Size(80, textBox4.Size.Height);
                        button.Size = new System.Drawing.Size(40, 73);
                        label.ForeColor = Color.Black;
                        combobox.ForeColor = Color.Black;
                        if (buttons.Count > 0)
                        {
                            button.Location = new Point(26, l + 80);
                            label.Location = new Point(73, l + 80);
                            combobox.Location = new Point(75, l + 120);
                            button22.Location = new Point(combobox.Location.X + combobox.Size.Width + 10, l + 120);
                            l = label.Location.Y;

                        }
                        else
                        {
                            button.Location = new Point(26, 340);
                            label.Location = new Point(73, 340);
                            combobox.Location = new Point(75, 380);
                            button22.Location = new Point(combobox.Location.X + combobox.Size.Width + 10, 378);
                            l = 340;
                        }
                        this.label3.Location = new Point(this.label3.Location.X, this.label3.Location.Y + 80);
                        answers.Add(parts[5]);
                        Controls.Add(label);
                        Controls.Add(button);
                        Controls.Add(combobox);
                        Controls.Add(button22);
                        labels.Add(label);
                        buttons.Add(button);
                        comboboxes.Add(combobox);
                        buttons2.Add(button22);
                        button.Click += new EventHandler(button_Click);
                        button22.Click += new EventHandler(button22_Click);

                    }
                }
            }
        }

        private void Questions_Save(object sender, FormClosingEventArgs e)
        {
            File.Delete(QuestionsSave);

            using (StreamWriter SR = new StreamWriter(File.Create(QuestionsSave)))
            {
             for(int i =0; i<labels.Count; i++)
                {
                    foreach(Label label in labels)
                    {
                        if(label == labels[i])
                        {
                            SR.Write(label.Text+ "#");
                        }
                    }
                    foreach (ComboBox combobox in comboboxes)
                    {
                        if (combobox == comboboxes[i])
                        {
                            SR.Write(combobox.Items[0] + "#" + combobox.Items[1] + "#" + combobox.Items[2] + "#" + combobox.Items[3] + "#");
                        }
                    }
                    SR.WriteLine(answers[i] + "#");


                }

            }

        }
    }
    }
