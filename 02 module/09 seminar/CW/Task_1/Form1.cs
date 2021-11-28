using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        bool a = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length == 0 && this.Opacity > 0.99)
                a = false;
            if (a && label1.Text.Length != 0)
                label1.Text = (label1.Text.Remove(label1.Text.Length - 1, 1));
            else if (a)
            {
                this.Opacity += 0.1;
                if (this.Opacity >= 0.9)
                {
                    label1.Text = "Кот уже ушел";
                    timer1.Stop();
                }
            }
            else
                this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                a = true;
            }
        }
    }
}
