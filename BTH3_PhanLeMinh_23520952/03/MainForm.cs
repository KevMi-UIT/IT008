﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
    }
}