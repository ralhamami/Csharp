using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Automobile
    {
        //cars mpg rating and current mileage
        private decimal decMPG;
        private int intMileage;

        //constructors
        //Default constructor
        public Automobile()
        {
            MilesPerGallon = 1;
        }

        //Constructor that takes arguments
        public Automobile(decimal decMyMPG, int intMyMileage)
        {
            decMPG = decMyMPG;
            intMileage = intMyMileage;
        }
        //Public properties and their mutators
        public decimal MilesPerGallon
        {

            get { return decMPG; }
            set
            {
                if (value >= 0)
                {
                    decMPG = value;
                }
                else
                {
                    //display an error msg telling the problem
                    Console.WriteLine("Invalid Number Entered");
                }

            }
        }

        public int Mileage
        {

            get { return intMileage; }
            set
            {
                if (value >= 0)
                {
                    intMileage = value;
                }
                else
                {
                    //display an error msg telling the problem
                    Console.WriteLine("Invalid Number Entered");
                }

            }
        }
    }
}
