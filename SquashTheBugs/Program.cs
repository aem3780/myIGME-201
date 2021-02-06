using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Allison Maus
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 compile time error, need ;
            //int i = 0; compile time error, cannot devide 1/0 with an int
            //declare double counter
            double i = 0;

            // declare string to hold all numbers
            string allNumbers = null;


            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) logic error, will not reach 10 
            for (i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null; compile time error, needs to be defined outside of the loop

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); //logic error, needs () to execute properly
                Console.Write(i + "/" + (i - 1) + " = ");


                // output the calculation based on the numbers
                Console.WriteLine(i / (i - 1));

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; logic error, i is all ready incremented in the for loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: "allNumbers); compile time error, 
            //need to add a + to write all numbers to console.
            Console.WriteLine("These numbers have been processed: "+allNumbers);
        }
    }
}
