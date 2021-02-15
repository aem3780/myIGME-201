using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_7
{
    //Class: Program
    //Author: Allie Maus
    //Purpose: PE8
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: Accept a string from the user and print it in reverse
        //Restrictions: none
        static void Main(string[] args)
        {
            //establish and initialize variables
            string word = "";
            string reverse = "";
            int i = 0;

            //accept word from user
            Console.WriteLine("Please enter a word: ");
            word = Console.ReadLine();

            //create an array of chars from word
            char[] cArray = word.ToCharArray();
            //add each letter from word to reverse in reverse order
            for (i = cArray.Length - 1; i > -1; i--){
                reverse += cArray[i];
            }

            //print reversed word to console
            Console.WriteLine(reverse);
        }
    }
}
