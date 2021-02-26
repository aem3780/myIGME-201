using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateReadLine
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 1 Question 3
    //Restrictions: none
    static class Program
    {
        //Method: Main
        //Purpose: to impersonate the Console.ReadLine() function with a delegate
        //Restrictions: none


        //declare the delegate function variable DelReadLine which must match
        //with the signature of the target function
        delegate string DelReadLine();
        static void Main(string[] args)
        {
            //create a variable of the new type DelReadLine
            DelReadLine delReadLine;

            //point the delegate function reference to Console.ReadLine();
            delReadLine = new DelReadLine(Console.ReadLine);

            //call the new function
            string userString = delReadLine();

        }
    }
}
