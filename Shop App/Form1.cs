﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }
    }
}
