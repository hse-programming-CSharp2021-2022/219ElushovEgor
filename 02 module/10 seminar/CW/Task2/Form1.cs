using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] s = { "one", "two", "three" };

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = string.Join("", textBox1.Lines);
            MessageBox.Show(str);
        }
    }
}
