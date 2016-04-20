using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void button1_Click(object sender, EventArgs e)
        {
            long installTime = Convert.ToInt64(textBox2.Text);
            long convertedTime = (installTime - 11644473600000000) / 1000000;//divide by 1000000 because we are going to add Seconds on to the base date
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            date = date.AddSeconds(convertedTime);
            textBox1.Text = date.ToString();
            Console.WriteLine(date);
        }

    }
}
