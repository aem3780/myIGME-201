using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Maus
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: PE6
    //Restrictions: None
    static class Program
    {
        //Method: Main
        //Purpose: To generate a random integer number between 0 and 100 (inclusive)
        //and have a player try to guess it. 
        //Restrictions: none
        static void Main(string[] args)
        {
            //create random number
            Random rand = new Random();
            //establish and initialize variables
            int i = 0;
            int turn = 1;
            int guess = 0;
            //generate random number between 0 and 100
            int randomNumber = rand.Next(0, 101);

            //Print out random number to console and instruct user on valid guesses
            Console.WriteLine(randomNumber);
            Console.WriteLine("Valid guess are numbers 0-100");

            //loop for allowing the user 8 valid guesses
            for(i = 0; i < 8; ++i)
            {
                //print what number turn to the console
                Console.WriteLine("Turn {0}: Enter your guess: ", turn);
                try
                {
                    //try converting string to int to see if the guess is valid
                    guess = Convert.ToInt32(Console.ReadLine());

                    //if the guess is converted check to see if it is between 0 and 100
                    if ((guess >= 0) && (guess <= 100))
                    {
                        //increment number of turns
                        turn++;
                        //if the guess is greater than random num print too high
                        if(guess>randomNumber)
                        {
                            Console.WriteLine("Too high.");
                        }
                        //if the guess is equal to random num and the user isn't out of turns
                        //print correct and number of turns used to console
                        else if((guess==randomNumber)&&(turn<=8))
                        {
                            Console.WriteLine("Correct! You won in {0} turns!",turn);
                            i = 10; //breaks loop
                        }
                        //if guess is less than the random num print too low
                        else
                        {
                            Console.WriteLine("Too low.");
                        }
                    }
                    //if guess is less than 0 or greater than 100 ask for valid int
                    else
                    {
                        Console.WriteLine("Please enter a valid integer.");
                        i--; //does not count invalid guess
                    }

                    
                }
                //if string cannot be converted to int ask for an integer
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                    i--; //does not count invalid guess

                }

              
            }
                //if out of guesses print the random number
                if (i == 8)
            {
                Console.WriteLine("You ran out of turns. The number was {0}.", randomNumber);
            }     

        }
    }
}
