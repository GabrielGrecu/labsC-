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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user") && (textBox2.Text == "pass"))
            {
                Form f = new Form2();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Utilizator/Parola incorecte!");
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
