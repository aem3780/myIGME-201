using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Question9
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 2 Q 8-10
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: create 2 objects of the child classes and calls a method that demonstrates polymorphism
        //Restrictions: none

        static void Main(string[] args)
        {
            //create new jazz object
            DanceClass jazz = new Jazz();
            //create new ballet object
            DanceClass ballet = new Ballet();

            //call MyMethod with each of the objects
            MyMethod(jazz);
            MyMethod(ballet);

        }

        //Method: MyMethod
        //Purpose: use the interfaces and derived classes to call the supported methods based on object type
        //Restrictions: none
        static void MyMethod(object obj)
        {
            //check type of object passed to method  
            Type type = obj.GetType();

            //if object is of the type Ballet
            if (type.Equals(typeof(Ballet)))
            {
                //create variable of iBallet interface type
                iBallet b;
                b = (iBallet)obj;
                //call methods using the interface 
                b.firstPosition();

                //create ballet object reference of type ballet
                Ballet balletRef = (Ballet)obj;
                balletRef.DanceMoves();
                balletRef.DanceRoutine();
            }
            //else if object is of the type Jazz 
            else if (type.Equals(typeof(Jazz)))
            {
                //create variable of iJazz interface type
                iJazz j;
                j = (iJazz)obj;
                //call methods using the interface 
                j.pirouette();

                //create jazz object reference of type Jazz
                Jazz jazzRef = (Jazz)obj;
                jazzRef.DanceMoves();
                jazzRef.DanceRoutine();
            }
        }

        //Class: DanceClass
        //Purpose: create parent abstract class DanceClass
        //Restrictions: none
        public abstract class DanceClass
        {
            public int classes;
            private string danceStudio;

            public string DanceStudio
            {
                get
                {
                    return danceStudio;
                }
                set
                {
                    danceStudio = value;
                }
            }

            public abstract void DanceMoves();

            public virtual void DanceRoutine()
            {
                Console.WriteLine("Dance Routine");
            }
        }

        //Class: Jazz
        //Purpose: create public class Jazz that inherits from DanceClass and the interface iJazz
        //Restrictions: none
        public class Jazz : DanceClass, iJazz
        {
            public string jazzMove;

            public void pirouette()
            {
                Console.WriteLine("Did a turn");
            }
            public override void DanceMoves()
            {
                Console.WriteLine("High Kick");
            }

            public override void DanceRoutine()
            {
                Console.WriteLine("Jazz Routine");
            }
        }


        //Class: Ballet
        //Purpose: create public class Ballet that inherits from DanceClass and the interface iBallet
        //Restrictions: none
        public class Ballet : DanceClass, iBallet
        {
            public string balletMove;

            public void firstPosition()
            {
                Console.WriteLine("Standing in first");
            }
            public override void DanceMoves()
            {
                Console.WriteLine("Plie");
            }

            public override void DanceRoutine()
            {
                Console.WriteLine("Ballet Routine");
            }
        }

        public interface iBallet
        {
            void firstPosition();
        }

        public interface iJazz
        {
            void pirouette();
        }
    }
}
