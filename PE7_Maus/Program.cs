using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PE7_Maus
{
        //Class: Program
        //Author: Allison Maus
        //Purpose: PE7
        //Restrictions: none
    static class Program
    {
        //Method: Main
        //Purpose: To create an interactive madlibs game
        //Restrictions: could not figure out how to replace {} and _

        static void Main(string[] args)
        {
            // declare and initialize necessary variables
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            string name = "";
            string resultString = "";
            string newWord = "";
            string answer = "";
            bool valid = false;

            // establish streamreader
            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("C:\\Users\\allis\\Desktop\\aem3780\\myIGME-201\\templates\\MadLibsTemplate.txt");

            //count number of Mad Lib stories
            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("C:\\Users\\allis\\Desktop\\aem3780\\myIGME-201\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");



                ++cntr;
            }

            input.Close();

            // do while the answer is either yes or no
            do
            {
                Console.WriteLine("Do you want to play MadLibs?");
                answer = Console.ReadLine();

                // if yes, execute Mad Libs game
                if (answer == "yes")
                {
                    valid = true;
                    // prompt the user for which Mad Lib they want to play (nChoice) and ask for their name
                    Console.WriteLine("What is your name?");
                    name = Console.ReadLine();
                    Console.WriteLine("Please choose a story between 1 and {0}.", numLibs);
                    nChoice = Convert.ToInt32(Console.ReadLine());

                    

                    // split the Mad Lib into separate words
                    string[] words = madLibs[nChoice].Split(' ');
                    // replace {} and _ 
                    words[nChoice] = words[nChoice].Replace("{", "");
                    words[nChoice] = words[nChoice].Replace("}", "");
                    words[nChoice] = words[nChoice].Replace("_", " ");


                    foreach (string word in words)
                    {
                        
                        if (word == "\n")
                        {
                            // if word is a "\n" append \n to the result string

                            resultString += '\n';
                        }
                        else if (word.StartsWith("{"))
                        {
                            // else if word is a placeholder
                            // prompt the user for the replacement
                            // and append the user response to the result string
                            
                            Console.WriteLine("Please enter a {0}", word);
                           
                            newWord = Console.ReadLine();
                            resultString += (newWord + " ");

                        }
                        else
                        {
                            // else append word to the result string

                            resultString += (word + " ");
                        }
                    }

                    // print resultString to console with users new words
                    Console.WriteLine(resultString);
                }
                // if answer is no print goodbye to console 
                else if (answer == "no")
                {
                    valid = true;
                    Console.WriteLine("Goodbye");
                }
                // if neither yes or no, prompt the user again to answer the question
                else
                {
                    Console.WriteLine("Please enter either yes or no.");
                    valid = false;
                }

            }
            while (valid == false);

            }
            
            
    }
}

