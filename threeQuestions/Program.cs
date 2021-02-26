using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeQuestions
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 1 Question 4
    //Restrictions: none
    static class Program
    {
        //Method: Main
        //Purpose: To recreate the 3 questions application
        //Restrictions: none

        //timeout boolean flag initialized to false
        static bool bTimeOut = false;
        //create timer
        static Timer timeOutTimer;
        static void Main(string[] args)
        {
            //declare local variables
            int answer;
            string oneAnswer;
            string twoAnswer;
            string threeAnswer;
            string againAnswer;

        start:

            Console.WriteLine();
            //create 5 second timer
            timeOutTimer = new Timer(5000);

            //add the TimesUp() delegate function to the timeOutTimer.Elapsed event handler
            //so that the TimesUp() will be called when the correct time elapses
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            // initialize timeout to false
            bTimeOut = false;

            //flag to trigger play again question
            bool bValid = false;        

            //ask the user for their selection 
            Console.Write("Choose your question (1-3): ");

            try
            {
                //convert input to int
                
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                goto start;
            }
           

            //if answer is a valid number, a number greater than 0 and less than 4
            if ((0 < answer) && (answer < 4))
            {

                //tell the user they have 5 seconds to answer the question
                Console.WriteLine("You have 5 seconds to answer the following question:");

                //if the user chooses 1
                if (answer == 1)
                {
                    //start the timer
                    timeOutTimer.Start();
                    //ask the user question 1
                    Console.WriteLine("What is your favorite color? ");
                    //read in answer from user
                    oneAnswer = Console.ReadLine();
                    //stop the timer
                    timeOutTimer.Stop();

                    //if the answer is correct and the time has not run out
                    if (oneAnswer.ToLower() == "black" && !bTimeOut)
                    {
                        //display well done 
                        Console.WriteLine("Well Done!");
                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                    }
                    //if time has run out
                    else if (bTimeOut == true)
                    {
                        //display answer and trigger play again question
                        Console.WriteLine("The answer is: black");
                        bValid = true;
                    }
                    //if answer is incorrect, display correct answer and set timeout to true
                    else
                    {
                        Console.WriteLine("Wrong! The answer is: black");
                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                        bTimeOut = true;
                    }
                }
                //if the user chooses 2
                else if (answer == 2)
                {
                    //start timer
                    timeOutTimer.Start();
                    //ask user question 2
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    //read in answer from user
                    twoAnswer = Console.ReadLine();
                    //stop timer
                    timeOutTimer.Stop();

                    //if answer is correct and time has not run out
                    if (twoAnswer == "42" && !bTimeOut)
                    {
                        //display well done
                        Console.WriteLine("Well Done!");
                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                    }
                    //if time has run out
                    else if (bTimeOut == true)
                    {
                        //display answer and trigger play again question
                        Console.WriteLine("The answer is: 42");
                        bValid = true;
                    }
                    //if answer is incorrect, display correct answer and set timeout to true
                    else
                    {
                        Console.WriteLine("Wrong! The answer is: 42");
                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                        bTimeOut = true;
                    }

                }
                //if user chooses 3 
                else
                {
                    //start timer
                    timeOutTimer.Start();
                    //ask user question 3
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    //read in answer from user
                    threeAnswer = Console.ReadLine();
                    //stop timer
                    timeOutTimer.Stop();

                    //if answer is correct and time has not run out 
                    if (threeAnswer == "what do you mean? african or european swallow?" && !bTimeOut)
                    {
                        //display well done
                        Console.WriteLine("Well Done!");
                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                    }
                    //if time has run out
                    else if (bTimeOut == true)
                    {
                        //display answer and trigger play again question
                        Console.WriteLine("The answer is: What do you mean? African or European swallow ? ");
                        bValid = true;
                    }
                    //if answer is incorrect, display correct answer and set timeout to true
                    else
                    {

                        Console.WriteLine("Wrong! The answer is: What do you mean? African or European swallow?");

                        //set boolean to true to ask the user if they want to play again
                        bValid = true;
                        bTimeOut = true;
                    }
                }



            }
            //if user does not enter a number 1-3 go to start and ask again
            else
            {
                goto start;
            }

            //if bValid is set to true ask the user if they want to play again
            if (bValid == true)
            {
                Console.Write("Play again? ");
                //read in answer from user
                againAnswer = Console.ReadLine();
                //if answer stays with y, go to start
                if (againAnswer.StartsWith("y"))
                {
                    goto start;
                }
                //if answer does not start with y, do nothing
            }
           



        }

        //Method: TimesUP
        //Purpose: Is called when allowed elapsed time is reached
        //Restrictions: User has to press enter if times up is called
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            //Print times up to console
            Console.WriteLine("Your time is up!");

            Console.WriteLine("Please press enter.");

            //set the bTimeOut flag to true to quit the game
            bTimeOut = true;

            //stop the timer
            timeOutTimer.Stop();
        }
    }
}
