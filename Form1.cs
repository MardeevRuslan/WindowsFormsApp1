﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Git_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
