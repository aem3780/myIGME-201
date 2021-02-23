using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProgram
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 1 Question 12
    //Restrictions: None
    static class Program
    {
        //Method: Main
        //Purpose:To find out if the user recieved a raise or not
        //Restrictions: none
        static void Main(string[] args)
        {
            //declare and initialize variables
            string sName;
            double dSalary = 30000;

            //Ask the user for their name and assign it to sName
            Console.WriteLine("What is your name? ");
            sName = Console.ReadLine();

            //if the result if GiveRaise is true
            if (GiveRaise(sName, ref dSalary) == true)
            {
                //print congrats to console with new salary
                Console.WriteLine("Congratulations on your raise! Your new salary is ${0}.", dSalary);
            }

        }

        //Method: GiveRaise
        //Purpose: To calculate the users new salary if they recieved a raise or not
        //Restrictions: none
        static bool GiveRaise(string name, ref double salary)
        {
            //if name is allie 
            if(name.ToLower() == "allie")
            {
                //add 19999.99 to current salary and return true
                salary += 19999.99;
                return true;
            }
            //if name is anything els e
            else
            {
                //return false
                return false;
            }
            

        }
    }
}
