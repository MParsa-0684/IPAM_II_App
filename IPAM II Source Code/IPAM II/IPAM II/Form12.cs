using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IPAM_II
{
    public partial class Form12 : Form
    {

        ArrayList labels = new ArrayList();
        ArrayList buttons = new ArrayList();
        int l;
        int n = 0;
        int y;
        int ly;
        int mi;
        string TasksSave = "Tasks.txt";
        bool first = false;
        string alltext = "";
        string labeldeleted = "";
        public Form12()
        {
           
            InitializeComponent();

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            using(StreamReader SR = new StreamReader(TasksSave))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if(line != "")
                    {
                        string[] parts = line.Split('#');
                        Label label = new Label();
                        Button button = new Button();
                        label.Text = parts[0] + "\n" + parts[1];
                        button.Text = "";
                        label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
                        label.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
                        button.BackColor = System.Drawing.Color.DarkRed;
                        label.Size = new System.Drawing.Size(800, 60);
                        button.Size = new System.Drawing.Size(30, 30);
                        label.ForeColor = Color.Black;
                        if (buttons.Count > 0)
                        {
                            button.Location = new Point(13, l + 60);
                            label.Location = new Point(50, l + 60);
                            l = label.Location.Y;

                        }
                        else
                        {
                            button.Location = new Point(13, 150);
                            label.Location = new Point(50, 150);
                            l = 150;
                        }
                        label3.Location = new Point(label3.Location.X, label3.Location.Y + 60);
                        Controls.Add(label);
                        Controls.Add(button);
                        labels.Add(label);
                        buttons.Add(button);
                        button.Click += new EventHandler(button_Click);


                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Button button = new Button();
            label.Text = textBox1.Text + "\n" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ", " + comboBox1.SelectedItem + ":" + comboBox2.SelectedItem + ", " + textBox2.Text;
            button.Text = "";
            label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
            label.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1EFFF");
            button.BackColor = System.Drawing.Color.DarkRed;
            label.Size = new System.Drawing.Size(800,60);
            button.Size = new System.Drawing.Size(30, 30);
            label.ForeColor = Color.Black;
            if (buttons.Count > 0)
            {
                button.Location = new Point(13, l + 60);
                label.Location = new Point(50, l + 60);
                l = label.Location.Y;
                
            }
            else
            {
                button.Location = new Point(13, 150);
                label.Location = new Point(50, 150);
                l = 150;
            }
            label3.Location = new Point(label3.Location.X, label3.Location.Y + 60);
            Controls.Add(label);
            Controls.Add(button);
            labels.Add(label);
            buttons.Add(button);
            button.Click += new EventHandler(button_Click);


        }

        private void button_Click(object sender, EventArgs e)
        {
            mi = 0;
            for(int i =0;i<buttons.Count; i++)
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
                    n = i;
                    break;
                }
            }
             foreach(Button button in buttons)
            {
                if(button.Location.Y > y)
                {
                    
                    button.Location = new Point(button.Location.X, button.Location.Y - 60);
                    
                }
            }
            foreach (Label label in labels)
            {
                if (label.Location.Y > y)
                {
                    label.Location = new Point(label.Location.X, label.Location.Y - 60);
                    l = label.Location.Y;
                    label3.Location = new Point(label3.Location.X, label3.Location.Y -60);

                }
            }
            if (l == y)
            {
                l = l - 60;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tasks_Save(object sender, FormClosingEventArgs e)
        {
            File.Delete(TasksSave);

            using (StreamWriter SR = new StreamWriter(File.Create(TasksSave)))
            {
                foreach (Label label in labels)
                {
                    string[] parts = (label.Text).Split('\n');
                    SR.WriteLine(parts[0] + "#" + parts[1]+"#");
                }
            }
         }
        }
}
