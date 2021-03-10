using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    //Class: program
    //Author: Allison Maus
    //Purpose: PE14
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: Using the class and interface definitions you created in #2, 
        //create objects of both classes and call MyMethod with each object.  
        //Restrictions: none

        static void Main(string[] args)
        {
            //create new objects of class Dog and Cat
            Dog dog = new Dog();
            Cat cat = new Cat();
            
            //Call MyMethod passing in the new object of the class
            MyMethod(dog);
            MyMethod(cat);

        }

        //Method: MyMethod
        //Purpose: to use an interface to call the common method of each class
        //restrictions: none
        public static void MyMethod(object myObject)
        {
 
            // declare IPet interface reference variable
            IPet iPet = (IPet)myObject;
            iPet.Play();
        }

        //Class: Dog
        //Purpose: Create new class of type dog that inherits the interface IPet
        //Restrictions: none
        public class Dog : IPet
        {
            //Method: Play
            //Purpose: Print the writeline personal to dog to console
            //Restrictions: none
            public void Play()
            {
                Console.WriteLine("Dog plays with tennis ball.");
            }
        }
        //Class: Cat
        //Purpose: Create new class of type cat that inherits the interface IPet
        //Restrictions: none
        public class Cat : IPet
        {
            //Method: Play
            //Purpose: Print the writeline personal to cat to console
            //Restrictions: none
            public void Play()
            {
                Console.WriteLine("Cat plays with mouse.");
            }
        }
        public interface IPet
        {
            void Play();
        }

    }
}
