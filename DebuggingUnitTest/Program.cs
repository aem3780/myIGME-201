using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY, compile time error, needs ;
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); compile time error, needs ""
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); logic error, what is read in isn't assigned to anything
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } 
            //while (int.TryParse(sNumber, out nX)); logic error, needs to be out nY not nX
            while (!int.TryParse(sNumber, out nY));

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}");logic error, does not print corresponding variable values, needs $
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }


        //int Power(int nBase, int nExponent) compile time error, needs public to precede type
        public static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; logic error, always returns 0 as answer
                returnVal = 1;

            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); run time error, throws stackOverflowException error  
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
                
            }

             //returnVal; compile time error, needs return to precede variable to return a value
            return returnVal;
        }
    }
}

