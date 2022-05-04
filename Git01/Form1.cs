using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string obj = "";
            obj = comboBox1.Text;
            pictureBox1.Image= Image.FromFile("\\git_gogo\\pic\\" + obj + ".gif");
        }

        
    }
}
