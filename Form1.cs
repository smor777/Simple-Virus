﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus4LogFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            while (1 > 0)
            {
                MessageBox.Show("You have been infected with a Virus!");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
               
        }
    }
}
