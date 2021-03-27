using System;

namespace StructToClass
{
    /*struct Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }*/

    //Class: Friend
    //Purpose: Creates class friend
    //Restrictions none

    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        //method for cloning object
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }
    }

    //class: Program
    //Author: Allison Maus
    //Purpose: Unite Test 2 Question 14
    class Program
    {
        //Method: Main
        //Purpose: converts the following code from using struct Friend to public class Friend and generates the same output
        //Restrictions: none
        static void Main(string[] args)
        {
            //create new object friend
            Friend friend = new Friend();

            //assign values to friend fields
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            //friend has become enemy, creates shallow copy of friend and assigns it to enemy so that friend is not changed 
            Friend enemy = (Friend)friend.Shallowcopy();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            //display friend values and enemy values
            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");


            /*Friend friend;
            Friend enemy;

            
            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");*/
        }
    }
}
