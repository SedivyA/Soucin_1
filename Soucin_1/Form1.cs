﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soucin_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int soucin = x * y;
            double podil = x / y;
            int souc = x + y;
            int rozdil = x - y;
            label1.Text = soucin.ToString();
            label2.Text = podil.ToString();
            label3.Text = souc.ToString();
            label4.Text = rozdil.ToString();
        }
    }
}
