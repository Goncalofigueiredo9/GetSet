﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSet
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
        Class1 sam = new Class1();
        private void Button1_Click(object sender, EventArgs e)
        {
            sam.recebe = textBox1.Text;
            textBox2.Text = sam.resultado;
        }
    }
}
