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
    public partial class Form13 : Form
    {
        ArrayList labels = new ArrayList();
        ArrayList buttons = new ArrayList();
        int l;
        int n = 0;
        int y;
        int ly;
        int mi;
        string EventsSave = "Events.txt";
        bool first = false;
        string alltext = "";
        string labeldeleted = "";
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Button button = new Button();
            string[] p = new string[] { "\r\n" };
            string[] lines = textBox1.Text.Split(p, StringSplitOptions.RemoveEmptyEntries);
            label.Text = "Time of Event : "+comboBox1.SelectedItem+":"+comboBox2.SelectedItem+" , Date of Event : "+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"\n"+lines[0]+"\n"+lines[1]+"\n"+lines[2]+"\n"+lines[3];
            button.Text = "";
            label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
            label.BackColor = System.Drawing.ColorTranslator.FromHtml("#046D8F");
            button.BackColor = System.Drawing.Color.DarkRed;
            label.Size = new Size(textBox1.Size.Width, textBox1.Size.Height);
            button.Size = new System.Drawing.Size(40, label.Size.Height);
            label.ForeColor = Color.Black;
            if (buttons.Count > 0)
            {
                button.Location = new Point(26, l + textBox1.Size.Height+30);
                label.Location = new Point(73, l + textBox1.Size.Height+30);
                l = label.Location.Y;

            }
            else
            {
                button.Location = new Point(26, 260);
                label.Location = new Point(73, 260);
                l = 250;
            }
            label3.Location = new Point(label3.Location.X, label3.Location.Y + textBox1.Size.Height + 30);
            Controls.Add(label);
            Controls.Add(button);
            labels.Add(label);
            buttons.Add(button);
            button.Click += new EventHandler(button_Click);


        }

        private void button_Click(object sender, EventArgs e)
        {
            mi = 0;
            Button butto1 = new Button();
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
                    n = i;
                    break;
                }
            }
            foreach (Button button in buttons)
            {
                if (button.Location.Y > y)
                {

                    button.Location = new Point(button.Location.X, button.Location.Y - (textBox1.Size.Height + 30));

                }
            }
            foreach (Label label in labels)
            {
                if (label.Location.Y > y)
                {
                    label.Location = new Point(label.Location.X, label.Location.Y - (textBox1.Size.Height + 30));
                    l = label.Location.Y;
                    label3.Location = new Point(label3.Location.X, label3.Location.Y - (textBox1.Size.Height + 30));

                }
            }
            if (l == y)
            {
                l = l - (textBox1.Size.Height + 30);
            }

        }

        private void Task_Save(object sender, FormClosingEventArgs e)
        {
            File.Delete(EventsSave);

            using (StreamWriter SR = new StreamWriter(File.Create(EventsSave)))
            {
                foreach (Label label in labels)
                {
                    string[] parts = (label.Text).Split('\n');
                    SR.WriteLine(parts[0] + "#" + parts[1] + "#" + parts[2] + "#"+ parts[3] + "#"+ parts[4] + "#");
                }
            }

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            using (StreamReader SR = new StreamReader(EventsSave))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if (line != "")
                    {
                        string[] parts = line.Split('#');
                        Label label = new Label();
                        Button button = new Button();
                        label.Text = parts[0]+"\n"+ parts[1] + "\n"+ parts[2] + "\n"+ parts[3] + "\n"+ parts[4] ;
                        button.Text = "";
                        label.Font = new System.Drawing.Font("Cambria", 17, FontStyle.Bold);
                        label.BackColor = System.Drawing.ColorTranslator.FromHtml("#046D8F");
                        button.BackColor = System.Drawing.Color.DarkRed;
                        label.Size = new Size(textBox1.Size.Width, textBox1.Size.Height);
                        button.Size = new System.Drawing.Size(40, label.Size.Height);
                        label.ForeColor = Color.Black;
                        if (buttons.Count > 0)
                        {
                            button.Location = new Point(26, l + textBox1.Size.Height + 30);
                            label.Location = new Point(73, l + textBox1.Size.Height + 30);
                            l = label.Location.Y;

                        }
                        else
                        {
                            button.Location = new Point(26, 260);
                            label.Location = new Point(73, 260);
                            l = 250;
                        }
                        label3.Location = new Point(label3.Location.X, label3.Location.Y + textBox1.Size.Height + 30);
                        Controls.Add(label);
                        Controls.Add(button);
                        labels.Add(label);
                        buttons.Add(button);
                        button.Click += new EventHandler(button_Click);


                    }
                }
            }

        }
    }
}
