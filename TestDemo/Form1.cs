using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int a = 1;
            int b = 2;
            int tmp = a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " asdasd";
        }
    }
}
