/*-----------------------------------------------------------------------------
* Author: Rayan Al-Hammami
* Date Created: 09/15/2015
* Purpose: Keeps track of FICO and Savings Statistics
----------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        //List collections for all customer info
        List<String> lstCustomerNames = new List<String>();
        List<int> lstFICOS = new List<int>();
        List<decimal> lstSavings = new List<decimal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Output variables for later parsing
            int intFICO;
            decimal decSavings;

            //Ensure that valid data has been entered for fico score, as well as valid range
            if (Int32.TryParse(txtFICO.Text,out intFICO) && intFICO >= 300 && intFICO <= 850)
            {
                //Ensure the same for saving input values
                if (Decimal.TryParse(txtSavings.Text, out decSavings) && decSavings >= 0)
                {
                    //Add all new values to repsective lists
                    lstCustomerNames.Add(txtCustomerName.Text);
                    lstFICOS.Add(intFICO);
                    lstSavings.Add(decSavings);
                    lstCustomers.Items.Add(txtCustomerName.Text);
                    //Clear all input textboxes and set focus to customer name
                    txtCustomerName.Clear();
                    txtFICO.Clear();
                    txtSavings.Clear();
                    txtCustomerName.Focus();
                }
                else
                {
                    //If fail, show error message, clear, and set focus
                    MessageBox.Show("Please enter numeric digits for savings greater than or equal to 0.");
                    txtSavings.Clear();
                    txtSavings.Focus();
                }
            }
            else 
            {
                //If fail, show error message, clear, and set focus
                MessageBox.Show("Please enter numeric digits for FICO between 300 and 850.");
                txtFICO.Clear();
                txtFICO.Focus();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Call all methods, and set all values
            int intBestFICO = 0;
            //Pass argument by reference to "return" second value from one method
            String strBestFICO = BestFICO(ref intBestFICO);
            decimal decBestSavings = 0;
            //Reference argument again
            String strBestSavings = BestSavings(ref decBestSavings);
            decimal decMedianFICO = MedianFICO();
            decimal decMedianSavings = MedianSavings();
            decimal decAverageFICO = AverageFICO();
            decimal decAverageSavings = AverageSavings();

            //Set all neccessary uneditable textboxes with output data
            txtBestFICO.Text = strBestFICO + ": " + intBestFICO;
            txtBestSavings.Text = strBestSavings + ": " + decBestSavings.ToString("c");
            txtMedFICO.Text = decMedianFICO.ToString("n1");
            txtMedSavings.Text = decMedianSavings.ToString("c");
            txtAvgFICO.Text = decAverageFICO.ToString("n1");
            txtAvgSavings.Text = decAverageSavings.ToString("c");
        }

        //Returns average savings
        public decimal AverageSavings()
        {
            return Convert.ToDecimal(lstSavings.Average());
        }
        
        //Returns average FICO
        public decimal AverageFICO()
        {
            return Convert.ToDecimal(lstFICOS.Average());
        }

        //Returns Median Savings
        public decimal MedianSavings()
        {
            int count = lstSavings.Count;
            if (count % 2 == 0)
            {
                decimal a = lstSavings[count / 2 - 1];
                decimal b = lstSavings[count / 2];
                return (a + b) / 2m;
            }
            else
            {
                return lstSavings[count / 2];
            }
        }

        //Returns MEdian FICO
        public decimal MedianFICO()
        {
            int count = lstFICOS.Count;
            if (count % 2 == 0)
            {
                int a = lstFICOS[count / 2 - 1];
                int b = lstFICOS[count / 2];
                return (a + b) / 2m;
            }
            else
            {
                return lstFICOS[count / 2];
            }

        }

        //Returns Best savings customer and uses pass by reference
        //to "return" value as well
        public String BestSavings(ref decimal decSavings) 
        {
            decSavings = lstSavings.Max();
            int intBestIndex = lstSavings.IndexOf(decSavings);
            return lstCustomerNames[intBestIndex];
        }

        //Returns best FICO customer and uses pass by reference
        //to "return" value as well
        public String BestFICO(ref int intBstFICO) 
        {
            intBstFICO = lstFICOS.Max();
            int intBestIndex = lstFICOS.IndexOf(intBstFICO);
            return lstCustomerNames[intBestIndex];
        }

        //Clear all statistics and return focus to beginning of form
        private void button1_Click(object sender, EventArgs e)
        {
            lstCustomerNames.Clear();
            lstFICOS.Clear();
            lstSavings.Clear();
            lstCustomers.Items.Clear();
            txtCustomerName.Clear();
            txtFICO.Clear();
            txtSavings.Clear();
            txtBestFICO.Clear();
            txtBestSavings.Clear();
            txtAvgFICO.Clear();
            txtAvgSavings.Clear();
            txtMedFICO.Clear();
            txtMedSavings.Clear();
            txtCustomerName.Focus();
        }

        //Exit the program
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
