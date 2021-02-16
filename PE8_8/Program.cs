using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: PE8
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: accept a string from the user and switch no's to yes'
        //Restrictions: none

        static void Main(string[] args)
        {

            //declare and initialize variables
            string sentence = "";
            string newSentence = "";

            //get input from user and assign it to sentence
            Console.WriteLine("Please enter a sentence with the word no in it: ");
            sentence = Console.ReadLine();

            //chance all letters to lower case for easier conversion
            sentence = sentence.ToLower();

            //set new sentence equal to sentence where no is replaced with yes
            newSentence = sentence.Replace("no", "yes");

            //write new sentence to console
            Console.WriteLine("Here is your new sentence: " + newSentence);
        }
    }
}
