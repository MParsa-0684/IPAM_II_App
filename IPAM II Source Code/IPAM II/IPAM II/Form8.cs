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
    public partial class Form8 : Form
    {
        public int[,] Board = new int[6, 6];
        public int[,] Board_C = new int[6, 6];
        public int Turn = 1;
        public int Not_Turn = 2;
        public int counter = 1;
        public int Zarf;
        public string Button = "";
        public Boolean f = false;

        public Form8()
        {
            InitializeComponent();
            for (int m = 0; m < 6; m++)
            {
                for (int n = 0; n < 6; n++)
                {
                    Board[m, n] = 0;
                }
            }
            Board[2, 2] = 1;
            Board[3, 3] = 1;
            Board[2, 3] = 2;
            Board[3, 2] = 2;
            Board_C = Board;
            WhiteBlack.Text = "White's Turn";

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var parts = ((Button)sender).Name.Split('_');
            int i = -1;
            int j = -1;
            int.TryParse(parts[1], out i);
            int.TryParse(parts[2], out j);
            //up_Vertical
            for (int x = i - 1; x >= 0; x--)
            {
                if (Board[x, j] == 0)
                    break;
                else if (Board[x, j] == Turn)
                {
                    for (int p = x + 1; p < i; p++)
                    {
                        Board_C[p, j] = Turn;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //down_Vertical
            for (int x = i + 1; x <= 5; x++)
            {
                if (Board[x, j] == 0)
                    break;
                else if (Board[x, j] == Turn)
                {
                    for (int p = x - 1; p > i; p--)
                    {
                        Board_C[p, j] = Turn;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //Horizontally-right
            for (int y = j + 1; y <= 5; y++)
            {
                if (Board[i, y] == 0)
                    break;
                else if (Board[i, y] == Turn)
                {
                    for (int p = y - 1; p > j; p--)
                    {
                        Board_C[i, p] = Turn;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //Horizontally-left
            for (int y = j - 1; y >= 0; y--)
            {
                if (Board[i, y] == 0)
                    break;
                else if (Board[i, y] == Turn)
                {
                    for (int p = y + 1; p < j; p++)
                    {
                        Board_C[i, p] = Turn;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //movarrab-NW-1
            int u = i + 1;
            int z = j + 1;
            while (u <= 5 && z <= 5)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u - 1;
                    int q = z - 1;
                    while (w > i && q > j)
                    {
                        Board_C[w, q] = Turn;
                        f = true;
                        w--;
                        q--;
                    }
                    break;
                }
                u++;
                z++;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //movarrab-NW-2
            u = i - 1;
            z = j - 1;
            while (u >= 0 && z >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u + 1;
                    int q = z + 1;
                    while (w < i && q < j)
                    {
                        Board_C[w, q] = Turn;
                        f = true;
                        w++;
                        q++;
                    }
                    break;
                }
                u--;
                z--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //movarrab-NE-1
            u = i + 1;
            z = j - 1;
            while (u <= 5 && z >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u - 1;
                    int q = z + 1;
                    while (w > i && q < j)
                    {
                        Board_C[w, q] = Turn;
                        f = true;
                        w--;
                        q++;
                    }
                    break;
                }
                u++;
                z--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }
            //movarrab-NE-2
            u = i - 1;
            z = j + 1;
            while (z <= 5 && u >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u + 1;
                    int q = z - 1;
                    while (w < i && q > j)
                    {
                        Board_C[w, q] = Turn;
                        f = true;
                        w++;
                        q--;
                    }
                    break;
                }
                z++;
                u--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                f = false;
            }



            if (Board_C[i, j] != Turn)
            {
                MessageBox.Show("    The bead doesn't have change color ability !", "Ooops...");
            }
            else
            {
                Board = Board_C;
                Align(Board);
                Zarf = Turn;
                Turn = Not_Turn;
                counter++;
                Not_Turn = Zarf;
                if (Turn == 1)
                {
                    WhiteBlack.Text = "White's Turn";
                }
                if (Turn == 2)
                {
                    WhiteBlack.Text = "Black's Turn";
                }
                if (counter == 33)
                {
                    Winner(Board_C);
                }
            }

        }
        private void Winner(int[,] Win)
        {
            int Black = 0;
            int White = 0;

            for (int W = 0; W < 6; W++)
            {
                for (int Z = 0; Z < 6; Z++)
                {
                    if (Win[W, Z] == 1)
                    {
                        White++;
                    }
                    if (Win[W, Z] == 2)
                    {
                        Black++;
                    }
                }
            }
            if (Black > White)
            {
                MessageBox.Show("     Black Player Won !!", " ! Congratulations ! ");
            }
            if (Black < White)
            {
                MessageBox.Show("     White Player Won !!", " ! Congratulations ! ");
            }
            if (Black == White)
            {
                MessageBox.Show("   ! The game equalised !", " ! The game equalised ! ");
            }
            Black = 0;
            White = 0;
        }
        private void Align(int[,] arr)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button = "b_" + i + "_" + j;
                    if (arr[i, j] == 0)
                    {
                        this.Controls[Button].BackColor = ColorTranslator.FromHtml("#C1EFFF");

                    }
                    else if (arr[i, j] == 1)
                    {
                        this.Controls[Button].BackColor = Color.White;
                        this.Controls[Button].Enabled = false;
                    }
                    else if (arr[i, j] == 2)
                    {
                        this.Controls[Button].BackColor = Color.Black;
                        this.Controls[Button].Enabled = false;
                    }
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < 6; m++)
            {
                for (int n = 0; n < 6; n++)
                {
                    Board[m, n] = 0;
                    Button = "b_" + m + "_" + n;
                    this.Controls[Button].Enabled = true;
                }
            }
            Board[2, 2] = 1;
            Board[3, 3] = 1;
            Board[2, 3] = 2;
            Board[3, 2] = 2;
            Board_C = Board;
            Turn = 1;
            Not_Turn = 2;
            counter = 0;
            Align(Board);
            WhiteBlack.Text = "White's Turn";

        }
    }
}
