﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();
            circularProgressBar1.Value = (int)fcpu;
            circularProgressBar1.Text = string.Format("{0:0.00}%", fcpu);

            circularProgressBar2.Value = (int)dram;
            circularProgressBar2.Text = string.Format("{0:0.00}%", dram);
        }
    }
}
