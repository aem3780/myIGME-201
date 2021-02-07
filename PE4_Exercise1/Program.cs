using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Exercise1
{
    //Class: program
    //Author: Allison Maus
    //Purpose: PE4 exercise 1
    //Restrictions: none
    static class Program
    {
        //Method: main
        //Purpose: accept two numbers from the user and display them
        //on screen, but reject the numbers if both are greater than 10
        //Restrictions: does not reach the catch in try catch, and does not work
        //if one number greater then 10 is entered
        static void Main(string[] args)
        {
            //initialize and declare variables
            int value1 = 0;
            int value2 = 0;
            bool valid = false;

            //asks the user to input two numbers while valid is false
            do
            {
                //ask user for input and convert the string to an integer
                Console.WriteLine("Please enter your first number:");
                value1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number:");
                value2 = Convert.ToInt32(Console.ReadLine());
                //try the comparison 
                try
                {
                    //if value1 is less than or equal to 10 and value 2 is less than
                    //or equal to 10 set valid to true
                    if((value1 <= 10)&(value2 <= 10))
                    {
                        valid = true;
                    
                    }
                    
              
                }
                //print to console if try fails
                catch
                {
                    Console.WriteLine("Please enter a new numbers");
                }

            }
            while (!valid);

            //display numbers on the console
            Console.WriteLine("Here are your numbers: {0} {1}", value1, value2);

           

            
        }
    }
}
