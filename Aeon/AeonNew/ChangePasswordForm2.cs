﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class ChangePasswordForm2 : Form
    {
        public ChangePasswordForm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == label5.Text)
            {
                ChangePasswordForm3 cpf3 = new ChangePasswordForm3();
                cpf3.Show();
                cpf3.label4.Text = this.label1.Text;
                this.Close();
            }

        }

        private void ChangePasswordForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
