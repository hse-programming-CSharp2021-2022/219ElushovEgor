using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a1 = 0, a2 = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            var a3 = a1 + 2 * a2;
            a1 = a2;
            a2 = a3;
            if (a3 < 0)
            {
                a1 = 0;
                a2 = 1;
                MessageBox.Show("Начнем сначала!");
                a3 = a1 + 2 * a2;
            }

            textBox1.Text = a3.ToString();
        }
    }
}
