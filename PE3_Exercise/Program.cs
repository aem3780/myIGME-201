using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_Exercise
{
    static class Program
    {
        //class: program
        //Author: Allie Maus
        //Purpose: PE3
        //Restrictions: none
        static void Main(string[] args)
        {
            //Method: Main
            //purpose: to recieve 4 int values from the user
            //and output th eproduct of those values
            //restrictions: none

            //initialize and define int variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int product = 0;

            //obtain the four integer values from the users
            //convert the string values from user to ints
            Console.WriteLine("Enter your first int value:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second int value:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your third int value:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your fourth int value:");
            num4 = Convert.ToInt32(Console.ReadLine());

            //calculate the product of all four ints
            product = num1 * num2 * num3 * num4;
            //print the value of the product to the console
            Console.WriteLine("The product of your four integers is: " + product);
        }
    }
}
