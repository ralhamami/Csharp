/*-----------------------------------------------------------------------------
* Author: Rayan Al-Hammami
* Date Created: 08/26/2015
* Purpose: This application calculates the newly assessed home value and proposed
           taxes based on a standard increase rate and tax exemption value.
----------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {   //No class level variables or constants as per requirements

        //Method for retrieving new property value that returns a double and takes 4 arguments to determine value
        public static double getNewPropertyValue(double dblPropertyValue, double dblRateIncrease, bool isResidingHere, int intTaxExemption)
        {
            //If the homeowner is residing here
            if (isResidingHere)
                //Deduct 25000 from property value as a tax exemption
                dblPropertyValue -= intTaxExemption;
            //Return this new property value multiplied by the increase rate
            //NOTE: I am assuming that the deduction was suppoed to be done before applying the increase, but
            //since I could very well have misunderstood, I wanted to leave you a note of it.
            return dblPropertyValue * dblRateIncrease;
        }

        //Method for retrieving new proposed taxes that takes two arguments for calculation
        public static double getProposedTaxes(double dblNewPropertyValue, double dblMileageRate)
        {
            //Return the mileage rate times every $1000 of value
            //NOTE: I am assuming taxes are calculated directly from the mileage rate. Again
            //I am assuming I may be wrong here as well, so I wanted to leave you a note just so
            //you would know what I had in mind.
            return (dblNewPropertyValue / 1000) * dblMileageRate;
        }

        //Method for displaying the new values after calculation
        public static void displayNewValues(double dblNewValue, double dblNewTax)
        {
            //Write line to console displaying each new values as a currency with escape sequences
            Console.WriteLine("\nNew Property Value: {0:C}\nNew Property Tax: {1:C}\n",dblNewValue,dblNewTax);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Declare constants for mileage rate, tax exemption rate, and rate increase percentage
            const double dblMILEAGE_RATE = 10.03;
            const int intTAX_EXEMPTION = 25000;
            const double dblRATE_INCREASE = 1.027;

            //Declare local variables for address, previous property value, homeowner status
            //new property value, and new property taxes
            string strAddress;
            double dblPropertyValue;
            bool isResidingHere;
            string strStatusResponse;
            double dblNewPropertyValue;
            double dblNewPropertyTax;

            //Prompt for address input
            Console.Write("Property Address: ");
            //Read address input into address variable
            strAddress = Console.ReadLine();
            //Prompt for property value
            Console.Write("Property Value (Previous Year): ");
            //Read, parse, and store property value into property value variable 
            dblPropertyValue = double.Parse(Console.ReadLine());
            //Prompt for homeowner status
            Console.Write("Currently Residing in House? (y or n) ");
            //Read homeowner status response into response variable
            strStatusResponse = Console.ReadLine();
            //Set value of isResidingHere accordingly
            if (strStatusResponse.StartsWith("y"))
            {
                isResidingHere = true;
                Console.WriteLine("\nQualified for Tax Exemption of {0:C}!", intTAX_EXEMPTION);
            }
            else
                isResidingHere = false;
            //Set new property value to result of getNewPropertyValue function call
            dblNewPropertyValue = getNewPropertyValue(dblPropertyValue, dblRATE_INCREASE
                , isResidingHere, intTAX_EXEMPTION);
            //Set new property tax value to result of getProposedTaxes function call
            dblNewPropertyTax = getProposedTaxes(dblNewPropertyValue, dblMILEAGE_RATE);
            //Call displayNewValues method to display both new values neatly formatted to console
            displayNewValues(dblNewPropertyValue, dblNewPropertyTax);
        }
        }
    }