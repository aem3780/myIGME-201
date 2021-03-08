using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    //class: program
    //Author: Allie Maus
    //Purpose: PE13
    //Restrictions: couldn't figure out how to get the correct output with the pet names
    //and I wasn't sure when to use Remove or RemoveAt
    class Program
    {
        //Method: Main
        //Purpose: create new pets and select random pets to do random methods
        //Restrictions: none
        static void Main(string[] args)
        {
            //create reference variables for the pets and interfaces
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            
            //create the lists of pets
            Pets pets = new Pets();

            //create random number generator 
            Random rand = new Random();
            
            //iterates 50 times
            for(int i = 0; i <50; i++)
            {
                
                //1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    
                    if (rand.Next(0, 2) == 0)
                    {
                        //add dog and prompt user for name, age and license 
                        
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("License: ");
                        string license = Console.ReadLine();
                        dog = new Dog(license, name, age);
                        pets.Add(dog);

                        continue;
                    }

                    else
                    {
                        //add cat and prompt user for name, age and license 
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("License: ");
                        string license = Console.ReadLine();
                        cat = new Cat();
                        pets.Add(cat);

                        continue;
                    }

                }
                else
                {
 
                    //choose a random pet from pets and choose a random activity for them to do
                    int num = rand.Next(0,pets.Count);
                    //set thisPet equal to the pet at index num
                    thisPet = pets[num];
                    //if null continue to next iteration of loop
                    if(pets[num] == null)
                    {
                        continue;
                    }
                    //else set interface according to type of pet
                    else
                    {
                        if(thisPet is IDog)
                        {
                            iDog = (IDog)thisPet;
                            //generate random number to correspond with the method called
                            int x = rand.Next(0, 5);
                            if(x == 0)
                            {
                                iDog.Eat();
                            }
                            if(x == 1)
                            {
                                iDog.Play();
                            }
                            if(x == 2)
                            {
                                iDog.GotoVet();
                            }
                            if(x == 3)
                            {
                                iDog.Bark();
                            }
                            else
                            {
                                iDog.NeedWalk();
                            }

                            
                        }
                        else
                        {
                            iCat = (ICat)thisPet;
                            //generate random number to correspond with the method called
                            int x = rand.Next(0, 5);
                            if (x == 0)
                            {
                                iCat.Eat();
                            }
                            if (x == 1)
                            {
                                iCat.Play();
                            }
                            if (x == 2)
                            {
                                iCat.GotoVet();
                            }
                            if (x == 3)
                            {
                                iCat.Purr();
                            }
                            else
                            {
                                iCat.Scratch();
                            }
                        }
                    }
                   






                }
             }
        }

        //Class: Pets
        //Purpose: to create a new class Pets
        //Restrictions: none
        public class Pets
        {
            //create new list of Pets
            public List<Pet> petList = new List<Pet>();

            //access the value at pets[num]
            public Pet this[int nPetEl]
            {
                //gets value of the object in the list 
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            //counts the number of items in the pet list and returns that number
            public int Count
            {

                get
                {
                    return petList.Count();
                }
            }
            //Method: Add
            //Purpose: adds instance of pet to the petlist
            //Restrictions: none
            public void Add (Pet pet)
            {
                petList.Add(pet);
            }

            //Method: Remove
            //Purpose: removes pet from list
            //Restrictions: none
            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            //Method: RemoveAt
            //Purpose: remove pet at certain index of list
            //restrictions: none
            public void RemoveAt(int petE1)
            {
                 petList.RemoveAt(petE1);
            }
        }
    }

    //Class: Pet
    //Purpose: create new abstract class Pet to be inherited from
    //Restrictions: none
    public abstract class Pet
    {
        //create field identifiers
        private string name;
        public int age;

        //get and set name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

        //constructor for pet
        public Pet()
            {

            }
        //second constructor for pet accepts name and age
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

       
        

    } 
    public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();

        }
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
            void GotoVet();

        }

    //class: Cat
    //purpose: create cat class that inherits from Pet and ICat
    //Restrictions: none
    public class Cat: Pet, ICat
        {
            public override void Eat()
        {
            Console.WriteLine("Yum cat food!");
        }

            public override void Play()
        {
            Console.WriteLine("Yay a mouse!");
        }
            public void Purr()
        {
            Console.WriteLine("Purrr");
        }
            public void Scratch()
        {
            Console.WriteLine("Scratch Scratch");
        }
            public override void GotoVet()
        {
            Console.WriteLine("I hate the vet");
        }

            public Cat()
            {

            }
              

        }

    //class: Dog
    //purpose: create cat class that inherits from Pet and IDog
    //Restrictions: none
    public class Dog: Pet, IDog
        {
            public string license;

            public override void Eat()
        {
            Console.WriteLine("Yum dog food!");
        }
            public override void Play()
        {
            Console.WriteLine("Yay a ball!");
        }
            public void Bark()
        {
            Console.WriteLine("Bark Bark!");
        }
            public void NeedWalk()
        {
            Console.WriteLine("I love walks!");
        }
            public override void GotoVet()
        {
            Console.WriteLine("Ugh not the vet.");
        }

        //Dog constructor, accepts license name and age
            public Dog(string szLicense, string szName, int nAge)
            {
                this.license = szLicense;
                base.Name = szName;
                base.age = nAge;

            }
        }

}
