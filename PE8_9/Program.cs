using System;

namespace PE8_9
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: PE8 
    //Restrictions: none
    class Program
    {
        //Methos: Main
        //Purpose: place quotation marks around each word in a sentence
        //Restrictions: none
        static void Main(string[] args)
        {
            //declare and initialize variables and arrays
            string sentence = "";
            string[] words;
            
            //Accept sentence from user and assign it to sentence
            Console.WriteLine("Please type any sentence: ");
            sentence = Console.ReadLine();
       
            //split sentence at the spaces and assign each seperate word to words array
            words = sentence.Split(' ');

            //for each word in words array write to console with quotes
            foreach (string word in words)
            {
                Console.Write("\"{0}\" ", word);
            }


        }
    }
}
