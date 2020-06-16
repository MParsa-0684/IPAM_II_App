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
using System.Reflection;

namespace IPAM_II
{
    public partial class Form15 : Form
    {
        string notesSave = "Notes.txt";
        ArrayList buttons = new ArrayList();
        ArrayList texts = new ArrayList();
        int l;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

            using(StreamReader SR = new StreamReader(notesSave))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if(line != "")
                    {
                        texts.Add(line);
                        string[] parts = line.Split('#');
                        Button button = new Button();
                        button.Size = button1.Size;
                        button.BackColor = ColorTranslator.FromHtml("#C1EFFF");
                        button.ForeColor = ColorTranslator.FromHtml("#046D8F");
                        button.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
                        button.Text = parts[0];
                        if(buttons.Count > 0)
                        {
                            button.Location = new Point(0, l + 30);
                            l = button.Location.Y;
                        }
                        else
                        {
                            button.Location = new Point(0, 43);
                            l = 43;
                        }
                        Controls.Add(button);
                        buttons.Add(button);
                        button.Click += new EventHandler(button_Click);
                    }

                }
            }
            ArrayList fonts = new ArrayList();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            comboBox1.DataSource = fonts;
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBox5.Items.Add(c.Name);
                this.comboBox6.Items.Add(c.Name);
            }
            textBox2.Font = new Font(textBox2.Font.Name, textBox2.Font.Size);

        }

        private void button_Click(object sender, EventArgs e)
        {
            using(StreamReader SR = new StreamReader(notesSave))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if(line != "" )
                    {
                        string[] parts = line.Split('$');
                        string[] p1 = parts[0].Split('#');
                        if(Convert.ToString(p1[0]) ==((Button)sender).Text )
                        {
                            textBox1.Text = "";
                            string[] p2 = parts[1].Split('#');
                            textBox2.Text = Convert.ToString(p1[0]);
                            for (int i=1; i<p1.Count(); i++)
                            {
                                textBox1.Text = textBox1.Text + p1[i] ;
                                textBox1.Text = textBox1.Text + "\r\n";
                            }
                            textBox1.Font = new Font(Convert.ToString(p2[0]), Convert.ToInt32(Convert.ToString(p2[1])));
                            textBox2.Font = new Font(Convert.ToString(p2[0]),textBox2.Font.Size);

                            if (Convert.ToString(p2[3]) == "RightToLeft")
                            {
                                textBox1.RightToLeft = RightToLeft.Yes;
                                textBox2.RightToLeft = RightToLeft.Yes;
                            }
                            else
                            {
                                textBox1.RightToLeft = RightToLeft.No;
                                textBox2.RightToLeft = RightToLeft.No;
                            }
                            textBox1.BackColor = Color.FromName(Convert.ToString(p2[4]));
                            textBox1.ForeColor = Color.FromName(Convert.ToString(p2[5]));
                            textBox2.BackColor = Color.FromName(Convert.ToString(p2[4]));
                            textBox2.ForeColor = Color.FromName(Convert.ToString(p2[5]));

                            if (Convert.ToString(p2[2]) == "Bold")
                            {
                                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                            }
                            if (Convert.ToString(p2[2]) == "Italic")
                            {
                                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);
                            }
                            if (Convert.ToString(p2[2]) == "Regular")
                            {
                                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                                textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);

                            }
                            if (Convert.ToString(p2[2]) == "Underline")
                            {
                                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                                textBox2.Font = new Font(textBox1.Font, FontStyle.Underline);

                            }
                            label6.Text = Convert.ToString(p2[6]);
                        }
                    }
                }
            }
        }

        private void Font_Change_TextBox(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Convert.ToString(comboBox1.SelectedItem),textBox1.Font.Size);
            textBox2.Font = new Font(Convert.ToString(comboBox1.SelectedItem), textBox2.Font.Size);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox4.SelectedItem) == "RightToLeft")
            {
                textBox1.RightToLeft = RightToLeft.Yes;
                textBox2.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                textBox1.RightToLeft = RightToLeft.No;
                textBox2.RightToLeft = RightToLeft.No;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox2.SelectedItem) == "Bold")
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Italic")
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);

            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Regular")
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Underline")
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Underline);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, float.Parse(Convert.ToString(comboBox3.SelectedItem)),textBox1.Font.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < texts.Count; i++)
            {
                string[] parts = (Convert.ToString(texts[i])).Split('$');
                string[] p2 = parts[1].Split('#');
                string[] p = new string[] { "\r\n" };
                string[] lines = textBox1.Text.Split(p, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToString(p2[6]) == label6.Text)
                {
                    texts[i] = "";
                    texts[i] = texts[i]+textBox2.Text+"#";
                    foreach(string line in lines)
                    {
                        texts[i] = texts[i] + line + "#";
                    }
                    texts[i] = texts[i] + "$"+textBox1.Font.FontFamily.Name+"#"+ textBox1.Font.Size+"#"+ textBox1.Font.Style+"#";
                   if(textBox1.RightToLeft == RightToLeft.Yes)
                    {
                        texts[i] = texts[i] + "RightToLeft#";
                    }
                    else
                    {
                        texts[i] = texts[i] + "LeftToRight#";
                    }
                    texts[i] = texts[i] + textBox1.BackColor.Name + "#" + textBox1.ForeColor.Name + "#"+label6.Text+"#$";
                }
            }
        }

        private void Form_Close(object sender, FormClosingEventArgs e)
        {
            File.Delete(notesSave);
            using (StreamWriter SR = new StreamWriter(File.Create(notesSave)))
            {
                if (texts.Count > 0)
                {
                    foreach (string text in texts)
                    {
                        SR.WriteLine(text);
                    }

                }
                else
                {
                    SR.Write("");
                }
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < texts.Count; i++)
            {
                string[] parts = (Convert.ToString(texts[i])).Split('$');
                string[] p2 = parts[1].Split('#');
                if (Convert.ToString(p2[6]) == Convert.ToString(label6.Text))
                    {
                      texts.Remove(texts[i]);
                     }
        
                
            }
       }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromName(Convert.ToString(comboBox5.SelectedItem));
            textBox2.BackColor = Color.FromName(Convert.ToString(comboBox5.SelectedItem));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromName(Convert.ToString(comboBox6.SelectedItem));
            textBox2.ForeColor = Color.FromName(Convert.ToString(comboBox6.SelectedItem));

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Size = button1.Size;
            button.BackColor = ColorTranslator.FromHtml("#C1EFFF");
            button.ForeColor = ColorTranslator.FromHtml("#046D8F");
            button.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);
            if (buttons.Count > 0)
            {
                button.Location = new Point(0, l + 30);
                l = button.Location.Y;
            }
            else
            {
                button.Location = new Point(0, 43);
                l = 33;
            }
            button.Text = "New Note" + button.Location.Y;
            Controls.Add(button);
            buttons.Add(button);
            button.Click += new EventHandler(button_Click);
            textBox1.Text = "";
            texts.Add("New Note" + button.Location.Y + "#New Note" + button.Location.Y + "#$Cambria#17#Regular#LeftToRight#LightYellow#Black#" + button.Location.Y + "#$");

        }
    }
}
