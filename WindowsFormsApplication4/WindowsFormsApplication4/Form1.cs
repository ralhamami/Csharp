﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        bool characters = false;
        bool uppercase = false;
        bool numeric = false;
        bool lowercase = false;
        char[] txtPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtPassword = textBox2.Text.ToArray();
            for (int i = 0; i < txtPassword.Count(); i++)
            {
                if (txtPassword[i] >= 65 && txtPassword[i] <= 90)
                    uppercase = true;
                if (txtPassword[i] >= 97 && txtPassword[i] <= 122)
                    lowercase = true;
                if (txtPassword[i] >= 48 && txtPassword[i] <= 57)
                    numeric = true;
                if (txtPassword.Count() >= 8)
                    characters = true;
            }
            if (characters && numeric && uppercase && lowercase)
                MessageBox.Show("Password Accepted");
            else
                MessageBox.Show("Password Not Accepted");

            characters = false;
            numeric = false;
            uppercase = false;
            lowercase = false;
        }
    }
}
