using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12Question3
{
    //Class: Program  
    //Author: Allison Maus 
    //Purpose: PE12Q3 
    //Restrictions: none 
    class Program
    {
        //Method: Main 
        //Purpose: Instantiate a MyDerivedClass object and output the string from  
        //its GetString method 
        static void Main(string[] args)
        {
            //create new MyDerivedClass object
            MyDerivedClass dClass = new MyDerivedClass();
            //store returned value in x and output to console
            string x = dClass.GetString();
            Console.WriteLine(x);



        }

        //Class: MyClass
        //Author: Allison Maus
        //Purpose: create public class MyClass 
        //Restrcitions: none
        public class MyClass
        {
            //store string in the private string myString
            private string myString = "word";

            //Method: GetString
            //Purpose: virtual method that returns the value of the private string myString
            public virtual string GetString()
            {
                return myString;
            }
        }

        //Class: MyDerivedClass
        //Author: Allison Maus
        //Purpose: derive from MyClass 
        //Restrcitions: none
        public class MyDerivedClass : MyClass
        {
            //override the GetString method to return the string from the base class
            public override string GetString()
            {
                return base.GetString() + " (output from derived class)";
            }
        }
    }
}
