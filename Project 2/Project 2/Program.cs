/*-----------------------------------------------------------------------------
* Author: Rayan Al-Hammami
* Date Created: September 1st, 2015
* Purpose: Application that estimates a defined trip's cost based on the 
  gathered MPG rating for two different cars.
----------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean var to keep track of if an exception is 
            //caught to loop user input
            bool noErrors = true;
            //All necessary temproary variables for user input
            decimal decMPGInput;
            int intMileageInput;
            string strStartCityInput, strEndCityInput;
            decimal decMilesInput, decGasPriceInput;

            //Keep taking user input while noErrors is false
            do
            {
                try
                {
                    //Reset noErrors variable to true
                    noErrors = true;
                    //Prompt for MPG and mileage of 1st and 2nd vehicle, convert them
                    //to appropriate data type and store them in their respective
                    //input variable. Then, create an automobile object
                    //for each vehicle based on the user's input.
                    Console.Write("Enter Miles-per-gallon for 1st Vehicle: ");
                    decMPGInput = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Mileage for 1st Vehicle: ");
                    intMileageInput = Convert.ToInt32(Console.ReadLine());
                    Automobile auto1 = new Automobile(decMPGInput, intMileageInput);

                    Console.Write("Enter Miles-per-gallon for 2nd Vehicle: ");
                    decMPGInput = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Mileage for 2nd Vehicle: ");
                    intMileageInput = Convert.ToInt32(Console.ReadLine());
                    Automobile auto2 = new Automobile(decMPGInput, intMileageInput);

                    //Prompt for all trip data, convert to necessary
                    //data type, and store in respective input variables
                    Console.Write("Enter Start City: ");
                    strStartCityInput = Console.ReadLine();
                    Console.Write("Enter End City: ");
                    strEndCityInput = Console.ReadLine();
                    Console.Write("Total Miles of Travel: ");
                    decMilesInput = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Average Gas Price-per-gallon: ");
                    decGasPriceInput = Convert.ToDecimal(Console.ReadLine());
                    //Create a new trip object with the input vairables
                    Trip trip = new Trip(strStartCityInput, strEndCityInput, decMilesInput, decGasPriceInput);

                    //Display estimated trip cost as a currency and mileage for both vehicles using WriteLine
                    Console.WriteLine("1st Car: " + trip.estimateTripCost(auto1.MilesPerGallon).ToString("c"));
                    Console.WriteLine("  New Mileage: " + (auto1.Mileage + trip.Miles));
                    Console.WriteLine("2nd Car: " + trip.estimateTripCost(auto2.MilesPerGallon).ToString("c"));
                    Console.WriteLine("  New Mileage: " + (auto2.Mileage + trip.Miles));
                    Console.Read();
                }
                //Catch any exceptions
                catch (Exception)
                {   //Print an error message
                    Console.WriteLine("Error with Input. Please try again.");
                    //and set noErrors to false so that the loop may continue
                    noErrors = false;
                }
                //while there are still errors
            } while (noErrors == false);
        }
    }
}
