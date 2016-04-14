using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkupCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcCost_Click(object sender, EventArgs e)
        {
            // declare variables for the price, markup, and cost
            decimal decPriceEntry, decMarkupEntry;
            decimal decCost;
            // if the user entered a valid price then
            if (decimal.TryParse(txtUserEntry.Text, out decPriceEntry))
            {   // if the user also entered a valid markup then
                if (decimal.TryParse(txtMarkup.Text, out decMarkupEntry))
                {   // calculate the cost based onthe price and markup
                    decCost = CalcCost(decPriceEntry, (decMarkupEntry/100m));
                    // display the cost with currency formatting
                    MessageBox.Show("Cost is " + decCost.ToString("c"));
                }
                else // else the markup entry is invalid
                {   // give the user an error message and set up for a correct entry
                    MessageBox.Show("Markup value is in error. Decimal numbers only, please.");
                    txtMarkup.Text = "";
                    txtMarkup.Focus();
                } // end else
            }
            else //else the price entered was invalid so...
            {  // give the user an error message and set the user up to make a correct entry
                MessageBox.Show("Price value is in error. Decimal numbers only, please.");
                txtUserEntry.Text = "";
                txtUserEntry.Focus();
            } // end else

        } // end calc cost



        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            // declare variables for the price, markup, and cost
            decimal decCostEntry, decMarkupEntry;
            decimal decPrice;
            // if the user entered a valid cost then
            if (decimal.TryParse(txtUserEntry.Text, out decCostEntry))
            {   // if the user also entered a valid markup then
                if (decimal.TryParse(txtMarkup.Text, out decMarkupEntry))
                {   // calculate the price based onthe cost and markup
                    decPrice = CalcPrice(decCostEntry, (decMarkupEntry / 100m));
                    // display the price with currency formatting
                    MessageBox.Show("Price is " + decPrice.ToString("c"));
                }
                else // else the markup entry is invalid
                {   // give the user an error message and set up for a correct entry
                    MessageBox.Show("Markup value is in error. Decimal numbers only, please.");
                    txtMarkup.Text = "";
                    txtMarkup.Focus();
                } // end else
            }
            else //else the cost entered was invalid so...
            {  // give the user an error message and set the user up to make a correct entry
                MessageBox.Show("Cost value is in error. Decimal numbers only, please.");
                txtUserEntry.Text = "";
                txtUserEntry.Focus();
            } // end else
        }
        
        //------------------------------------------------------------------------------------------
        // Method CalcCost
        // Parameters: decPrice - valid values include all positive decimal values
        //             decMarkupPerc - valid values include all positive decimal values
        // Return Value: decCalculatedCost - valid values include all postive decimal values
        // Processing: Given an item's price and a markup percentage charged, this method 
        //             calculates the original cost of the item
        //------------------------------------------------------------------------------------------

        private decimal CalcCost(decimal decPrice, decimal decMarkupPerc)
        {   // declare a var to hold the calculated cost
            decimal decCalculatedCost;
            // the cost = the price divided by (1 + the markup percentage)
            decCalculatedCost = (decPrice / (1.0m + decMarkupPerc));
            // return the calculated cost
            return (decCalculatedCost);
        }

        //CalcPrice method
        private decimal CalcPrice(decimal decCost, decimal decMarkupPerc)
        {   //declare a var to hold the calculated price
            decimal decCalculatedPrice;
            //the price = the cost times (1 + markup percentage)
            decCalculatedPrice = (decCost * (1.0m + decMarkupPerc));
            //return the calculated price
            return (decCalculatedPrice);
        } 

    }
}
