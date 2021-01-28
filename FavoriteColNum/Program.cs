using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteColNum

{
    //Class: Program
    //Author: Allie Maus
    //Purpose: Console Read/Write and Exception Handling excercise
    //Restrictions: none

    static class Program
    {
        //Method: Main
        //Purpose: Prompt the user for their favorite color and number
        //        Output their fave color (in limited text colors) their fav number of times
        //Restrictions: none
        static void Main(string[] args)
        {
            //declare our needed variables
            string color = null;
            int favNum = 0;
            int i;
            bool bValid = false;

            //Prompt user for their fav color
            Console.Write("Enter your favorite color:\t");

            //read color from keyboard
            color = Console.ReadLine();


            do
            { //Propmt user for their favorite number
                Console.Write("Enter your favorite number:\t");
                try
                {
                    //read number from keyboard
                    favNum = Convert.ToInt32(Console.ReadLine());

                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }
            } while (!bValid);

            //change the text color to their fave color
            switch (color.ToLower())
            {
                case "red":
                case "purple":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            //loop to output their favorite color, their fave number of times
            for(i = 0; i < favNum; i++)
            {
                Console.WriteLine("Your favorite color is {0}. Your fave number is {1} " ,color, favNum);

            }


        }
    }
}
