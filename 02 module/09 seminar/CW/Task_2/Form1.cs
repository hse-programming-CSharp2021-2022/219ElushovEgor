using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in list)
                listBox1.Items.Add(item);
        }
        List<string> list = new List<string>() { "1", "2", "3", "4"};
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var item in list)
                listBox1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Список пуст или нет выделенного!");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
