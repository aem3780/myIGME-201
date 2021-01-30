using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maus_HelloWorld
{
    //Class: Program
    //Author: Allie Maus
    //Purpose: Create a console application and experiment with c# syntax
    //Restrictions: none
    static class Program
    {
        //Method: Main
        //Purpose: To print out Hello World to console and experiment with c# Syntax
        //Restrictions: none

        static void Main(string[] args)
        {
            //Prints hello world to console
            Console.WriteLine("Hello World!");
            //Prints my name to console
            Console.WriteLine("Allie Maus");

            //for loop that prints numbers 0-11 to console
            for(int num = 0; num <12; ++num)
            {
                Console.WriteLine(num);
            }
        }
    }
}
