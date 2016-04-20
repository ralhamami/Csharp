using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If the textbox contains "smumallah"
            if (textBox1.Text == "smumallah")
            {   //Then print out this message
                label1.Text = "Hello Sana! Welcome back!.";
            }
            //Otherwise
            else
            {   //Print out this message
                label1.Text = "You are not an authorized user, asshooe.";
            }
        }
    }
}
