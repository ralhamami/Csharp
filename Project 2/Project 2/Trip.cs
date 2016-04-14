using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Trip
    {
        //private data for required for trip
        private string strStartCity;
        private string strEndCity;
        private decimal decMiles;
        private decimal decAverageGasPrice;


        //constructors
        //Default constructor, no parameters
        public Trip()
        {
        }

        //Constructor that takes arguments
        public Trip(string strMyStartingCity, string strMyEndCity,
            decimal decMyMiles, decimal decAvgGasPrice)
        {
            strStartCity = strMyStartingCity;
            strEndCity = strMyEndCity;
            decMiles = decMyMiles;
            decAverageGasPrice = decAvgGasPrice;
        }
        // public properties and mutators
        public string StartCity
        {
            get
            {
                return strStartCity;

            }
            set
            { // if the string, trimmed of blanks, has any value
                if (value.Trim().Length > 0)
                {//the set the startcity
                    strStartCity = value;
                }
                else
                {
                    // error msg
                    Console.WriteLine("Invalid Name Entered");
                }
            }
        }

        public string EndCity
        {
            get
            {
                return strEndCity;

            }
            set
            { // if the string, trimmed of blanks, has any value
                if (value.Trim().Length > 0)
                {//the set the startcity
                    strEndCity = value;
                }
                else
                {
                    // error msg
                    Console.WriteLine("Invalid Name Entered");
                }
            }
        }

        public decimal Miles
        {
            get
            {
                return decMiles;
            }
            set
            {
                if (value > 0)
                {
                    decMiles = value;
                }
                else
                {
                    //error msg
                    Console.WriteLine("Invalid Number Entered");
                }
            }
        }

        public decimal AverageGasPrice
        {
            get
            {
                return decAverageGasPrice;
            }
            set
            {
                if (value > 0)
                {
                    decAverageGasPrice = value;
                }
                else
                {
                    //error msg
                    Console.WriteLine("Invalid Number Entered");
                }
            }
        }

        //Function to estimate trip cost based on
        //diving the number of total miles by the MPG
        //rating, and the result of that multiplied
        //by the average gas price
        public decimal estimateTripCost(decimal dblMilesPerGallon)
        {
            return (decMiles / dblMilesPerGallon) * decAverageGasPrice;
        }
    }
}