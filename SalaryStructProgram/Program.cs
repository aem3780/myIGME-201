using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryStructProgram
{   
    struct Employee
        {
            // member variables with defined accessibility
            public string sName;
            public double dSalary;

            // member property for accessing the GiveRaise function
           public bool GiveRaise()
           {
            //if sName is allie
            if(this.sName.ToLower()=="allie")
            {
                //add 19999.99 to current salary and return true
                this.dSalary += 19999.99;
                return true;
            }
            //if sName is anything else
            else
            {
                return false;
            }

        }
        }

    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 1 
    //Restrictions: none
    static class Program
    {
        //Method: Main
        //Purpose: Use a struct to recreate question 12
        //Restrictions: none
        static void Main(string[] args)
        {

            //create new Employee
            Employee person = new Employee();

            //assign allie sName
            person.sName = "Allie";
            //assign 30000 to dSalary
            person.dSalary = 30000;

            //if GIveRaise is true print congrats to console and new salary
            if (person.GiveRaise()==true)
            {
                Console.WriteLine("Congratulations on your raise! Your new salary is ${0}.", person.dSalary);
            }



            

        }

       
    }
}
