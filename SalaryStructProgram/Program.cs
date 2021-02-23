using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryStructProgram
{   
    struct employee
        {
            public string sName;
            public double dSalary;

            public bool GiveRaise()
            {
            if(this.sName.ToLower()=="allie")
            {
                //add 19999.99 to current salary and return true
                this.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }

        }
        }
    class Program
    {
        static void Main(string[] args)
        {


            employee person = new employee();

            person.sName = "Allie";
            person.dSalary = 30000;

            if (person.GiveRaise()==true)
            {
                Console.WriteLine("Congratulations on your raise! Your new salary is ${0}.", person.dSalary);
            }



            

        }

       
    }
}
