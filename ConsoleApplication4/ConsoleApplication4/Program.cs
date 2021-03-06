﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        
    
        static void Main(string[] args)
        {
            HelloMsg speak = new HelloMsg();
            speak.Speak();
            ConfigureCUI();
            // Wait for Enter key to be pressed.
            Console.ReadLine();
        }

        private static void ConfigureCUI()
        {
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
