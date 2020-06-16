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
    public partial class Form5 : Form
    {
        Uri WebURL;


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
             WebURL = webBrowser1.Url;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = WebURL;
        }
    }
}
